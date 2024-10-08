using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТРПО27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void фон1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C:\Users\Анастасия\source\repos\ТРПО27\ТРПО27\Resources\landscape12.jpg");
        }

        private void фон2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C:\Users\Анастасия\source\repos\ТРПО27\ТРПО27\Resources\landscape13.jpg");
        }

        private void фон3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C:\Users\Анастасия\source\repos\ТРПО27\ТРПО27\Resources\landscape11.jpg");
        }

        private void обИгреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Была написана в 8 рук. Прыгай и не умрай.");
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажмите <<Сменить фон>> для смены фона.\n" +
                "Нажмите<<Выбрать персонажа>> для смены персонажа.\n" +
                "Нажмите<<Старт>> для начала игры.");
        }
    }
}
