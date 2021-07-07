using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWork
{
    public partial class FormOne : Form
    {
        public FormOne()
        {
            InitializeComponent();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            //Закрытие программы через меню
            this.Close();
        }

        private void MenuOpen_Click(object sender, EventArgs e)
        {
            //Очистка формы
            //Выбор и отображение папок из диалогового окна
            treeView1.Nodes.Clear();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                var rootDirectoryInfo = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                treeView1.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Пейзаж горы.jpg":
                    pictureBox1.Image = Image.FromFile("D:\\С#\\WindowsForms\\TestWork\\Изображения\\Пейзаж\\Пейзаж горы.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Пейзаж луга.jpg":
                    pictureBox1.Image = Image.FromFile("D:\\С#\\WindowsForms\\TestWork\\Изображения\\Пейзаж\\Пейзаж луга.jpg");
                    break;
                case "Пейзаж озеро.jpg":
                    pictureBox1.Image = Image.FromFile("D:\\С#\\WindowsForms\\TestWork\\Изображения\\Пейзаж\\Пейзаж озеро.jpg");
                    break;
                case "Пейзаж с лодкой.jpg":
                    pictureBox1.Image = Image.FromFile("D:\\С#\\WindowsForms\\TestWork\\Изображения\\Пейзаж\\Пейзаж с лодкой.jpg");
                    break;
                case "Пейзаж туман.jpg":
                    pictureBox1.Image = Image.FromFile("D:\\С#\\WindowsForms\\TestWork\\Изображения\\Пейзаж\\Пейзаж туман.jpg");
                    break;
                case "Нью-Йорк.jpg":
                    pictureBox1.Image = Image.FromFile("D:\\С#\\WindowsForms\\TestWork\\Изображения\\Города\\Нью-Йорк.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Москва.jpg":
                    pictureBox1.Image = Image.FromFile("D:\\С#\\WindowsForms\\TestWork\\Изображения\\Города\\Москва.jpg");
                    break;
                case "Париж.jpg":
                    pictureBox1.Image = Image.FromFile("D:\\С#\\WindowsForms\\TestWork\\Изображения\\Города\\Париж.jpg");
                    break;
                case "Сидней.jpg":
                    pictureBox1.Image = Image.FromFile("D:\\С#\\WindowsForms\\TestWork\\Изображения\\Города\\Сидней.jpg");
                    break;
                case "Ауди.jpg":
                    pictureBox1.Image = Image.FromFile("D:\\С#\\WindowsForms\\TestWork\\Изображения\\Машины\\Ауди.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Феррари.jpg":
                    pictureBox1.Image = Image.FromFile("D:\\С#\\WindowsForms\\TestWork\\Изображения\\Машины\\Феррари.jpg");
                    break;
                case "Ламба.jpg":
                    pictureBox1.Image = Image.FromFile("D:\\С#\\WindowsForms\\TestWork\\Изображения\\Машины\\Ламба.jpg");
                    break;
                case "Астон.jpg":
                    pictureBox1.Image = Image.FromFile("D:\\С#\\WindowsForms\\TestWork\\Изображения\\Машины\\Астон.jpg");
                    break;
            }
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            //Создание дерева для выбора папок с изображениями
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            return directoryNode;
        }
        private void FormOne_Load(object sender, EventArgs e)
        {
            
        }

        private void MenuinfoProgramme_Click(object sender, EventArgs e)
        {
            //Вывод сообщения о программе 
            MessageBox.Show(
                "Приложение по загрузке и отображению картинок \nиз локальной папки." +
                "\nСозданно в рамках тестового задания." +
                "\n\nВыполнил: Мишин Н.А",
                "О программе");
                
        
        }
    }
}
