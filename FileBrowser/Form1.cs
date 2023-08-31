using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileBrowser
{
    public partial class Form1 : Form
    {
        private string currentFolderPath;
        public Form1()
        {
            InitializeComponent();
        }

        protected void ClearAllFields()
        {
            listBoxFolders.Items.Clear();
            listBoxFiles.Items.Clear();
            textBoxFolder.Text = "";
            textBoxFolder.Text = "";
            textBoxFileName.Text = "";
            textBoxCreationTime.Text = "";
            textBoxLastAccessTime.Text = "";
            textBoxLastWriteTime.Text = "";
            textBoxFileSize.Text = "";
        }

        // Отображение информации о файлах в текстовых полях
        protected void DisplayFileInfo(string fileFullName)
        {

            // Создание объекта класса FileInfo. В конструктор класса
            // передается строка, содержащая путь к файлу
            FileInfo theFile = new FileInfo(fileFullName);
            if (!theFile.Exists)
                throw new FileNotFoundException("Файл не найден: "
                + fileFullName);

            // Вывод информации об имени файла
            textBoxFileName.Text = theFile.Name;

            // Вывод информации о дате создания файла
            textBoxCreationTime.Text =
            theFile.CreationTime.ToLongTimeString();

            // Вывод информации о времени последнего доступа к файлу
            textBoxLastAccessTime.Text =
            theFile.LastAccessTime.ToLongDateString();
            textBoxLastWriteTime.Text =
            theFile.LastWriteTime.ToLongDateString();

            // Вывод информации о размере файла
            textBoxFileSize.Text = theFile.Length.ToString() + "bytes";
            // Разрешение перемещения, удаления, копирования файлов
            textBoxNewPath.Text = theFile.FullName;
            textBoxNewPath.Enabled = true;
            buttonCopyTo.Enabled = true;
            buttonDelete.Enabled = true;
            buttonMoveTo.Enabled = true;
        }

        // Отображение содержимого заданной папки в двух окнах списков
        // listBoxFolders и listBoxFiles
        protected void DisplayFolderList(string folderFullName)
        {
            // Создание объекта класса DirectoryInfo. В конструктор класса
            // передается строка, содержащая путь к папке
            DirectoryInfo theFolder = new DirectoryInfo(folderFullName);

            // Свойство Exists позволяет проверить, существует ли объект файловой
            // системы
            if (!theFolder.Exists)
                throw new DirectoryNotFoundException("Папка не найдена: "
                + folderFullName);
            ClearAllFields();
            DisableMoveFeatures();
            textBoxFolder.Text = theFolder.FullName;
            currentFolderPath = theFolder.FullName;
            // Вывод в элемент listBoxFolders списка всех вложенных папок в папке
            foreach (DirectoryInfo nextFolder in theFolder.GetDirectories())
                listBoxFolders.Items.Add(nextFolder.Name);
            // Вывод в список listBoxFiles списка всех файлов в папке
            foreach (FileInfo nextFile in theFolder.GetFiles())
                listBoxFiles.Items.Add(nextFile.Name);
        }
        void DisableMoveFeatures()
        {
            textBoxNewPath.Text = "";
            textBoxNewPath.Enabled = false;
            buttonCopyTo.Enabled = false;
            buttonDelete.Enabled = false;
            buttonMoveTo.Enabled = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                try
                {
                    listBoxDisks.Items.Insert(0, "Имя диска: " + drive.Name);
                    listBoxDisks.Items.Insert(1, "Файловая система: " + drive.DriveFormat);
                    listBoxDisks.Items.Insert(2, "Тип диска: " + drive.DriveType);
                    listBoxDisks.Items.Insert(3, "Объем доступного свободного места (в байтах): " + drive.AvailableFreeSpace);
                    listBoxDisks.Items.Insert(4, "Готов ли диск: " + drive.IsReady);
                    listBoxDisks.Items.Insert(5, "Корневой каталог диска: " + drive.RootDirectory);
                    listBoxDisks.Items.Insert(6, "Общий объем свободного места, доступного на диске (в байтах): " + drive.TotalFreeSpace);
                    listBoxDisks.Items.Insert(7, "Размер диска (в байтах): " + drive.TotalSize);
                    listBoxDisks.Items.Insert(8, "Метка тома диска: " + drive.VolumeLabel);
                    listBoxDisks.Items.Insert(0, "");
                }
                catch { }

            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedString = listBoxFolders.SelectedItem.ToString();
                string fullPathName = Path.Combine(currentFolderPath, selectedString);
                DisplayFolderList(fullPathName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            try
            {
                string folderPath = new FileInfo(currentFolderPath).DirectoryName;
                DisplayFolderList(folderPath);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                string folderPath = textBoxInput.Text;
                DirectoryInfo theFolder = new DirectoryInfo(folderPath);
                if (theFolder.Exists)
                {
                    DisplayFolderList(theFolder.FullName);
                    return;
                }
                FileInfo theFile = new FileInfo(folderPath);
                if (theFile.Exists)
                {
                    DisplayFolderList(theFile.Directory.FullName);
                    int index = listBoxFiles.Items.IndexOf(theFile.Name);
                    listBoxFiles.SetSelected(index, true);
                    return;
                }
                throw new FileNotFoundException("There is no file or folder with" + "this name: " + textBoxInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedString = listBoxFiles.SelectedItem.ToString();
                string fullFileName = Path.Combine(currentFolderPath, selectedString);
                DisplayFileInfo(fullFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(currentFolderPath,
                textBoxFileName.Text);
                string query = "Удалить файл\n" + filePath + "?";
                if (MessageBox.Show(query,
                  "Удалить файл?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Delete(filePath);
                    DisplayFolderList(currentFolderPath);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete file. The following exception"
                       + "occurred:\n" + ex.Message, "Failed");
            }
        }

    private void buttonCopyTo_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(currentFolderPath,
                textBoxFileName.Text);
                string query = "Копировать файл\n" + filePath + "\nto"
                + textBoxNewPath.Text + "?";
                if (MessageBox.Show(query,
                    "Копировать файл?", MessageBoxButtons.YesNo) ==
                      DialogResult.Yes)
                {
                    File.Copy(filePath, textBoxNewPath.Text);
                    DisplayFolderList(currentFolderPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно выполнить копирование файла" + "occurred:\n" + ex.Message, "Failed");
            }

        }

        private void buttonMoveTo_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(currentFolderPath,
                textBoxFileName.Text);
                string query = "Переместить файл\n" + filePath + "\nto "
                + textBoxNewPath.Text + "?";
                if (MessageBox.Show(query,
                     "Переместить файл?", MessageBoxButtons.YesNo) ==
                      DialogResult.Yes)
                {
                    File.Move(filePath, textBoxNewPath.Text);
                    DisplayFolderList(currentFolderPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно выполнить перемещение файла" + "occurred:\n" + ex.Message, "Failed");
            }
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void listBoxDisks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFileSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
