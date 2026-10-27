using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            btn_save_as = new ToolStripMenuItem();
            параметрыСтраницыToolStripMenuItem = new ToolStripMenuItem();
            печатьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            правкаToolStripMenuItem = new ToolStripMenuItem();
            отменитьToolStripMenuItem = new ToolStripMenuItem();
            вырезатьToolStripMenuItem = new ToolStripMenuItem();
            копироватьToolStripMenuItem = new ToolStripMenuItem();
            вставитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            поискСПомощьюBingToolStripMenuItem = new ToolStripMenuItem();
            найтиToolStripMenuItem = new ToolStripMenuItem();
            найтиДалееToolStripMenuItem = new ToolStripMenuItem();
            заменитьToolStripMenuItem = new ToolStripMenuItem();
            перейтиToolStripMenuItem = new ToolStripMenuItem();
            выделелитьВсеToolStripMenuItem = new ToolStripMenuItem();
            времяИДатаToolStripMenuItem = new ToolStripMenuItem();
            форматToolStripMenuItem = new ToolStripMenuItem();
            переносПоСловамToolStripMenuItem = new ToolStripMenuItem();
            шрифтToolStripMenuItem = new ToolStripMenuItem();
            видToolStripMenuItem = new ToolStripMenuItem();
            масштабToolStripMenuItem = new ToolStripMenuItem();
            увеличитьToolStripMenuItem = new ToolStripMenuItem();
            уменьшитьToolStripMenuItem = new ToolStripMenuItem();
            восстановитьМасштабПоУмолчаниюToolStripMenuItem = new ToolStripMenuItem();
            строкаСостоянияToolStripMenuItem = new ToolStripMenuItem();
            about = new ToolStripMenuItem();
            просмотретьСправкуToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            vScrollBar1 = new VScrollBar();
            hScrollBar1 = new HScrollBar();
            panel1 = new Panel();
            vScrollBar2 = new VScrollBar();
            saveFileDialog1 = new SaveFileDialog();
            printDialog1 = new PrintDialog();
            openFileDialog1 = new OpenFileDialog();
            fontDialog1 = new FontDialog();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, правкаToolStripMenuItem, форматToolStripMenuItem, видToolStripMenuItem, about });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(685, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, открытьToolStripMenuItem, сохранитьToolStripMenuItem, btn_save_as, параметрыСтраницыToolStripMenuItem, печатьToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(204, 22);
            создатьToolStripMenuItem.Text = "Создать";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 204);
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(204, 22);
            открытьToolStripMenuItem.Text = "Открыть...";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(204, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // btn_save_as
            // 
            btn_save_as.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 204);
            btn_save_as.Name = "btn_save_as";
            btn_save_as.Size = new Size(204, 22);
            btn_save_as.Text = "Сохранить как...";
            btn_save_as.Click += сохранитьКакToolStripMenuItem_Click;
            // 
            // параметрыСтраницыToolStripMenuItem
            // 
            параметрыСтраницыToolStripMenuItem.Name = "параметрыСтраницыToolStripMenuItem";
            параметрыСтраницыToolStripMenuItem.Size = new Size(204, 22);
            параметрыСтраницыToolStripMenuItem.Text = "Параметры страницы...";
            // 
            // печатьToolStripMenuItem
            // 
            печатьToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 204);
            печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            печатьToolStripMenuItem.Size = new Size(204, 22);
            печатьToolStripMenuItem.Text = "Печать...";
            печатьToolStripMenuItem.Click += печатьToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(204, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // правкаToolStripMenuItem
            // 
            правкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { отменитьToolStripMenuItem, вырезатьToolStripMenuItem, копироватьToolStripMenuItem, вставитьToolStripMenuItem, удалитьToolStripMenuItem, поискСПомощьюBingToolStripMenuItem, найтиToolStripMenuItem, найтиДалееToolStripMenuItem, заменитьToolStripMenuItem, перейтиToolStripMenuItem, выделелитьВсеToolStripMenuItem, времяИДатаToolStripMenuItem });
            правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            правкаToolStripMenuItem.Size = new Size(59, 20);
            правкаToolStripMenuItem.Text = "Правка";
            // 
            // отменитьToolStripMenuItem
            // 
            отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            отменитьToolStripMenuItem.Size = new Size(214, 22);
            отменитьToolStripMenuItem.Text = "Отменить";
            // 
            // вырезатьToolStripMenuItem
            // 
            вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            вырезатьToolStripMenuItem.Size = new Size(214, 22);
            вырезатьToolStripMenuItem.Text = "Вырезать";
            // 
            // копироватьToolStripMenuItem
            // 
            копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            копироватьToolStripMenuItem.Size = new Size(214, 22);
            копироватьToolStripMenuItem.Text = "Копировать";
            // 
            // вставитьToolStripMenuItem
            // 
            вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            вставитьToolStripMenuItem.Size = new Size(214, 22);
            вставитьToolStripMenuItem.Text = "Вставить";
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(214, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // поискСПомощьюBingToolStripMenuItem
            // 
            поискСПомощьюBingToolStripMenuItem.Name = "поискСПомощьюBingToolStripMenuItem";
            поискСПомощьюBingToolStripMenuItem.Size = new Size(214, 22);
            поискСПомощьюBingToolStripMenuItem.Text = "Поиск с помощью Bing...";
            // 
            // найтиToolStripMenuItem
            // 
            найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            найтиToolStripMenuItem.Size = new Size(214, 22);
            найтиToolStripMenuItem.Text = "Найти...";
            // 
            // найтиДалееToolStripMenuItem
            // 
            найтиДалееToolStripMenuItem.Name = "найтиДалееToolStripMenuItem";
            найтиДалееToolStripMenuItem.Size = new Size(214, 22);
            найтиДалееToolStripMenuItem.Text = "Найти далее";
            // 
            // заменитьToolStripMenuItem
            // 
            заменитьToolStripMenuItem.Name = "заменитьToolStripMenuItem";
            заменитьToolStripMenuItem.Size = new Size(214, 22);
            заменитьToolStripMenuItem.Text = "Заменить...";
            // 
            // перейтиToolStripMenuItem
            // 
            перейтиToolStripMenuItem.Name = "перейтиToolStripMenuItem";
            перейтиToolStripMenuItem.Size = new Size(214, 22);
            перейтиToolStripMenuItem.Text = "Перейти...";
            // 
            // выделелитьВсеToolStripMenuItem
            // 
            выделелитьВсеToolStripMenuItem.Name = "выделелитьВсеToolStripMenuItem";
            выделелитьВсеToolStripMenuItem.Size = new Size(214, 22);
            выделелитьВсеToolStripMenuItem.Text = "Выделелить все";
            // 
            // времяИДатаToolStripMenuItem
            // 
            времяИДатаToolStripMenuItem.Name = "времяИДатаToolStripMenuItem";
            времяИДатаToolStripMenuItem.Size = new Size(214, 22);
            времяИДатаToolStripMenuItem.Text = "Время и дата";
            // 
            // форматToolStripMenuItem
            // 
            форматToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { переносПоСловамToolStripMenuItem, шрифтToolStripMenuItem });
            форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            форматToolStripMenuItem.Size = new Size(62, 20);
            форматToolStripMenuItem.Text = "Формат";
            // 
            // переносПоСловамToolStripMenuItem
            // 
            переносПоСловамToolStripMenuItem.Name = "переносПоСловамToolStripMenuItem";
            переносПоСловамToolStripMenuItem.Size = new Size(183, 22);
            переносПоСловамToolStripMenuItem.Text = "Перенос по словам";
            // 
            // шрифтToolStripMenuItem
            // 
            шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            шрифтToolStripMenuItem.Size = new Size(183, 22);
            шрифтToolStripMenuItem.Text = "Шрифт...";
            шрифтToolStripMenuItem.Click += шрифтToolStripMenuItem_Click;
            // 
            // видToolStripMenuItem
            // 
            видToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { масштабToolStripMenuItem, строкаСостоянияToolStripMenuItem });
            видToolStripMenuItem.Name = "видToolStripMenuItem";
            видToolStripMenuItem.Size = new Size(39, 20);
            видToolStripMenuItem.Text = "Вид";
            // 
            // масштабToolStripMenuItem
            // 
            масштабToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { увеличитьToolStripMenuItem, уменьшитьToolStripMenuItem, восстановитьМасштабПоУмолчаниюToolStripMenuItem });
            масштабToolStripMenuItem.Name = "масштабToolStripMenuItem";
            масштабToolStripMenuItem.Size = new Size(180, 22);
            масштабToolStripMenuItem.Text = "Масштаб";
            // 
            // увеличитьToolStripMenuItem
            // 
            увеличитьToolStripMenuItem.Name = "увеличитьToolStripMenuItem";
            увеличитьToolStripMenuItem.Size = new Size(288, 22);
            увеличитьToolStripMenuItem.Text = "Увеличить";
            // 
            // уменьшитьToolStripMenuItem
            // 
            уменьшитьToolStripMenuItem.Name = "уменьшитьToolStripMenuItem";
            уменьшитьToolStripMenuItem.Size = new Size(288, 22);
            уменьшитьToolStripMenuItem.Text = "Уменьшить";
            // 
            // восстановитьМасштабПоУмолчаниюToolStripMenuItem
            // 
            восстановитьМасштабПоУмолчаниюToolStripMenuItem.Name = "восстановитьМасштабПоУмолчаниюToolStripMenuItem";
            восстановитьМасштабПоУмолчаниюToolStripMenuItem.Size = new Size(288, 22);
            восстановитьМасштабПоУмолчаниюToolStripMenuItem.Text = "Восстановить масштаб по умолчанию";
            // 
            // строкаСостоянияToolStripMenuItem
            // 
            строкаСостоянияToolStripMenuItem.CheckOnClick = true;
            строкаСостоянияToolStripMenuItem.Name = "строкаСостоянияToolStripMenuItem";
            строкаСостоянияToolStripMenuItem.Size = new Size(180, 22);
            строкаСостоянияToolStripMenuItem.Text = "Строка состояния";
            // 
            // about
            // 
            about.DropDownItems.AddRange(new ToolStripItem[] { просмотретьСправкуToolStripMenuItem, оПрограммеToolStripMenuItem });
            about.Name = "about";
            about.Size = new Size(65, 20);
            about.Text = "Справка";
            // 
            // просмотретьСправкуToolStripMenuItem
            // 
            просмотретьСправкуToolStripMenuItem.Name = "просмотретьСправкуToolStripMenuItem";
            просмотретьСправкуToolStripMenuItem.Size = new Size(195, 22);
            просмотретьСправкуToolStripMenuItem.Text = "Просмотреть справку";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(195, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(685, 471);
            textBox1.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(762, 167);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(10, 213);
            vScrollBar1.TabIndex = 2;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Dock = DockStyle.Bottom;
            hScrollBar1.Location = new Point(0, 471);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(685, 17);
            hScrollBar1.TabIndex = 3;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // panel1
            // 
            panel1.Controls.Add(vScrollBar2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(hScrollBar1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 488);
            panel1.TabIndex = 4;
            // 
            // vScrollBar2
            // 
            vScrollBar2.Dock = DockStyle.Right;
            vScrollBar2.Location = new Point(668, 0);
            vScrollBar2.Name = "vScrollBar2";
            vScrollBar2.Size = new Size(17, 471);
            vScrollBar2.TabIndex = 4;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 512);
            Controls.Add(panel1);
            Controls.Add(vScrollBar1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem btn_save_as;
        private ToolStripMenuItem параметрыСтраницыToolStripMenuItem;
        private ToolStripMenuItem печатьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem отменитьToolStripMenuItem;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem поискСПомощьюBingToolStripMenuItem;
        private ToolStripMenuItem найтиToolStripMenuItem;
        private ToolStripMenuItem найтиДалееToolStripMenuItem;
        private ToolStripMenuItem заменитьToolStripMenuItem;
        private ToolStripMenuItem перейтиToolStripMenuItem;
        private ToolStripMenuItem выделелитьВсеToolStripMenuItem;
        private ToolStripMenuItem времяИДатаToolStripMenuItem;
        private ToolStripMenuItem форматToolStripMenuItem;
        private ToolStripMenuItem переносПоСловамToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem about;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private ToolStripMenuItem масштабToolStripMenuItem;
        private ToolStripMenuItem строкаСостоянияToolStripMenuItem;
        private ToolStripMenuItem просмотретьСправкуToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private TextBox textBox1;
        private VScrollBar vScrollBar1;
        private HScrollBar hScrollBar1;
        private Panel panel1;
        private VScrollBar vScrollBar2;
        private ToolStripMenuItem увеличитьToolStripMenuItem;
        private ToolStripMenuItem уменьшитьToolStripMenuItem;
        private ToolStripMenuItem восстановитьМасштабПоУмолчаниюToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
        private OpenFileDialog openFileDialog1;
        private FontDialog fontDialog1;
    }
}