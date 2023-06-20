using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GeneratorSuper
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            // Подписываемся на событие Click кнопки btnGenerate и указываем обработчик btnGenerate_Click
            btnGenerate.Click += btnGenerate_Click;

            // Настраиваем внешний вид текстового поля txtPassword
            CustomizeTextBox(txtPassword);

            // Подписываемся на событие Paint элемента picture_box1 и указываем обработчик picture_box1_Paint
            picture_box1.Paint += picture_box1_Paint;


            // Подписываемся на событие CheckedChanged радиокнопки rbComputer и указываем обработчик rbType_CheckedChanged
            rbComputer.CheckedChanged += rbType_CheckedChanged;
            // Подписываемся на событие CheckedChanged радиокнопки rbSegmented и указываем обработчик rbType_CheckedChanged
            rbSegmented.CheckedChanged += rbType_CheckedChanged;

            // Изначально отключаем выбор количества сегментов в числовом поле numericSegmentCount
            numericSegmentCount.Enabled = false; 

            // Изначально отключаем выбор размера сегмента в числовом поле numericSegmentSize
            numericSegmentSize.Enabled = false; 

            this.MaximumSize = new Size(986, 537);   // Устанавливаем максимальный размер формы


        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Настраиваем внешний вид флажков chkUppercase, chkLowercase, chkSymbols и т.д.
            // Задаем им фоновое изображение и режим масштабирования
            // Аналогично настраиваем внешний вид остальных элементов управления
            chkUppercase.BackColor = Color.Transparent;
            chkUppercase.BackgroundImage = picture_box1.BackgroundImage;
            chkUppercase.BackgroundImageLayout = ImageLayout.Stretch;

            chkLowercase.BackColor = Color.Transparent;
            chkLowercase.BackgroundImage = picture_box1.BackgroundImage;
            chkLowercase.BackgroundImageLayout = ImageLayout.Stretch;

            chkSymbols.BackColor = Color.Transparent;
            chkSymbols.BackgroundImage = picture_box1.BackgroundImage;
            chkSymbols.BackgroundImageLayout = ImageLayout.Stretch;

            chkPovtorenie.BackColor = Color.Transparent;
            chkPovtorenie.BackgroundImage = picture_box1.BackgroundImage;
            chkPovtorenie.BackgroundImageLayout = ImageLayout.Stretch;

            chkNumbers.BackColor = Color.Transparent;
            chkNumbers.BackgroundImage = picture_box1.BackgroundImage;
            chkNumbers.BackgroundImageLayout = ImageLayout.Stretch;

            rbComputer.BackColor = Color.Transparent;
            rbComputer.BackgroundImage = picture_box1.BackgroundImage;
            rbComputer.BackgroundImageLayout = ImageLayout.Stretch;


            rbSegmented.BackColor = Color.Transparent;
            rbSegmented.BackgroundImage = picture_box1.BackgroundImage;
            rbSegmented.BackgroundImageLayout = ImageLayout.Stretch;

            label1.BackColor = Color.Transparent;
            label1.BackgroundImage = picture_box1.BackgroundImage;
            label1.BackgroundImageLayout = ImageLayout.Stretch;

            label2.BackColor = Color.Transparent;
            label2.BackgroundImage = picture_box1.BackgroundImage;
            label2.BackgroundImageLayout = ImageLayout.Stretch;


            label3.BackColor = Color.Transparent;
            label3.BackgroundImage = picture_box1.BackgroundImage;
            label3.BackgroundImageLayout = ImageLayout.Stretch;

            label4.BackColor = Color.Transparent;
            label4.BackgroundImage = picture_box1.BackgroundImage;
            label4.BackgroundImageLayout = ImageLayout.Stretch;

            label5.BackColor = Color.Transparent;
            label5.BackgroundImage = picture_box1.BackgroundImage;
            label5.BackgroundImageLayout = ImageLayout.Stretch;

            label6.BackColor = Color.Transparent;
            label6.BackgroundImage = picture_box1.BackgroundImage;
            label6.BackgroundImageLayout = ImageLayout.Stretch;

            label7.BackColor = Color.Transparent;
            label7.BackgroundImage = picture_box1.BackgroundImage;
            label7.BackgroundImageLayout = ImageLayout.Stretch;

            label8.BackColor = Color.Transparent;
            label8.BackgroundImage = picture_box1.BackgroundImage;
            label8.BackgroundImageLayout = ImageLayout.Stretch;

            label9.BackColor = Color.Transparent;


            // Устанавливаем выбор радиокнопки rbComputer по умолчанию
            rbComputer.Checked = true;
            // Обновляем видимость кнопок в зависимости от выбранного типа пароля
            UpdateButtonsVisibility();

        }

        private void btnGenerate_Paint(object sender, PaintEventArgs e)
        {
            // Делает кнопку с закругленными краями, но решили отказаться от данной идеи и оставить квадратной
            // Обработчик события Paint кнопки btnGenerate, реализующий закругление кнопки и отрисовку обводки
            // Используется объект GraphicsPath для создания закругленной формы кнопки
            // Затем форма устанавливается в качестве региона кнопки
            // Далее, используя объекты Pen и Graphics, производится отрисовка обводки кнопки

            // Преобразуем отправителя события в тип Button
            var button = (Button)sender;

            // Создаем объект GraphicsPath для определения формы кнопки с закругленными углами
            var path = new GraphicsPath();
            var borderRadius = 20; // Радиус закругления, настройте его в соответствии с вашими требованиями

            // Добавляем дуги для формирования закругленных углов
            path.AddArc(0, 0, borderRadius * 2, borderRadius * 2, 180, 90);
            path.AddArc(button.Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2, 270, 90);
            path.AddArc(button.Width - borderRadius * 2, button.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90);
            path.AddArc(0, button.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90);
            path.CloseAllFigures();

            // Устанавливаем Region кнопки в соответствии с GraphicsPath
            button.Region = new Region(path);

            using (var pen = new Pen(Color.White, 2)) // Цвет и толщина обводки
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }
        private void picture_box1_Paint(object sender, PaintEventArgs e)
        {
            // Аналогичный обработчик события Paint для элемента picture_box1
            // Закругление и отрисовка обводки выполняются аналогично коду в btnGenerate_Paint
            var pictureBox = (PictureBox)sender;
            var path = new GraphicsPath();
            var borderRadius = 20; // Радиус закругления, настройте его в соответствии с вашими требованиями


            path.AddArc(0, 0, borderRadius * 2, borderRadius * 2, 180, 90);
            path.AddArc(pictureBox.Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2, 270, 90);
            path.AddArc(pictureBox.Width - borderRadius * 2, pictureBox.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90);
            path.AddArc(0, pictureBox.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90);
            path.CloseAllFigures();

            pictureBox.Region = new Region(path);

            using (var pen = new Pen(Color.White, 2)) // Цвет и толщина обводки
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }

        }
        private void CustomizeTextBox(TextBox textBox)
        {
            // Метод, настраивающий внешний вид текстового поля
            // Задается стиль границы, цвет фона, высота и шрифт текста и др.
            textBox.BorderStyle = BorderStyle.None;
            textBox.BackColor = Color.White;
            textBox.AutoSize = false;
            textBox.Height = 30;
            textBox.Font = new Font(textBox.Font.FontFamily, 12);
            textBox.Padding = new Padding(10, 5, 10, 5);
            textBox.Multiline = true;
            textBox.TextAlign = HorizontalAlignment.Left;
            textBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox.Width, textBox.Height, 10, 10));
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private string GenerateComputerPassword(int length, bool includeUppercase, bool includeLowercase, bool includeNumbers, bool includeSymbols)
        {
            // Метод генерации компьютерного пароля без тире
            // Принимает параметры длины пароля и флагов включения различных символов
            // Внутри метода выполняется генерация пароля на основе заданных параметров
            // Возвращает сгенерированный пароль
            string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            string numberChars = "0123456789";
            string symbolChars = "!@#$%^&*";

            StringBuilder password = new StringBuilder();
            Random random = new Random();

            string charSet = "";
            if (includeUppercase)
                charSet += uppercaseChars;
            if (includeLowercase)
                charSet += lowercaseChars;
            if (includeNumbers)
                charSet += numberChars;
            if (includeSymbols)
                charSet += symbolChars;


            for (int i = 0; i < length; i++)
            {
                int randomIndex = random.Next(0, charSet.Length);
                password.Append(charSet[randomIndex]);
            }

            if (chkPovtorenie.Checked)
            {
                // Удаляем повторяющиеся символы рядом
                StringBuilder filteredPassword = new StringBuilder();
                filteredPassword.Append(password[0]);

                for (int i = 1; i < password.Length; i++)
                {
                    if (password[i] != password[i - 1])
                        filteredPassword.Append(password[i]);
                }

                password = filteredPassword;
            }

            return password.ToString();
        }
        private string GenerateSegmentedPassword(int segmentCount, int segmentSize, bool includeUppercase, bool includeLowercase, bool includeNumbers, bool includeSymbols)
        {
            string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            string numberChars = "0123456789";
            string symbolChars = "!@#$%^&*";

            StringBuilder password = new StringBuilder();
            Random random = new Random();

            string charSet = "";
            if (includeUppercase)
                charSet += uppercaseChars;
            if (includeLowercase)
                charSet += lowercaseChars;
            if (includeNumbers)
                charSet += numberChars;
            if (includeSymbols)
                charSet += symbolChars;



            // Генерация сегментов пароля

            for (int i = 0; i < segmentCount; i++)
            {
                for (int j = 0; j < segmentSize; j++)
                {
                    int randomIndex = random.Next(0, charSet.Length);
                    password.Append(charSet[randomIndex]);
                }

                // Добавление тире после каждого сегмента, кроме последнего
                if (i < segmentCount - 1)
                    password.Append("-");
            }

            return password.ToString();
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtPassword.TextAlign = HorizontalAlignment.Center;
            bool includeUppercase = chkUppercase.Checked;
            bool includeLowercase = chkLowercase.Checked;
            bool includeNumbers = chkNumbers.Checked;
            bool includeSymbols = chkSymbols.Checked;

            string password;

            if (rbComputer.Checked)
            {
                // Генерация компьютерного пароля без тире
                int length = (int)numericLength.Value;
                int segmentCount = (int)numericSegmentCount.Value;
                int segmentSize = (int)numericSegmentSize.Value;
                password = GenerateComputerPassword(length, includeUppercase, includeLowercase, includeNumbers, includeSymbols);

            }
            else
            {

                int segmentCount = (int)numericSegmentCount.Value;
                int segmentSize = (int)numericSegmentSize.Value;
                // Генерация сегментированного пароля с тире
                password = GenerateSegmentedPassword(segmentSize, segmentCount, includeUppercase, includeLowercase, includeNumbers, includeSymbols);
            }

            txtPassword.Text = password;
        }
        private void rbType_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButtonsVisibility(); // Вызов метода при изменении выбора типа пароля
        }
        private void UpdateButtonsVisibility()
        {
            if (rbComputer.Checked)
            {
                label6.Visible = false; // Убираем текстовое поле
                chkPovtorenie.Visible = true; // Включаем "Исключить повторение"
                numericSegmentCount.Enabled = false; // Отключаем выбор количества сегментов
                numericLength.Enabled = true; // Включаем шкалу "Длина пароля:"
                numericSegmentSize.Enabled = false; // Отключаем выбор размера сегмента
                numericSegmentCount.Visible = false; // Убираем с глаз пользователя элемент управления
                numericSegmentSize.Visible = false; // Убираем с глаз пользователя элемент управления
                numericLength.Visible = true; // Возвращаем элемент управления на экран
                label7.Visible = false; // Убираем с глаз пользователя
                label8.Text = "Длина пароля:"; // Меняем текст на указанный
                numericSegmentCount.Location = new Point(numericLength.Location.X, numericLength.Location.Y); // Меняю местами numericSegmentCount и numericLength
                numericLength.Location = new Point(numericSegmentCount.Location.X, numericSegmentCount.Location.Y); // Меняю местами numericSegmentCount и numericLength
            }
            else
            {
                label6.Visible = true; // Возвращаем элемент управления на экран
                label7.Visible = true; // Возвращаем элемент управления на экран
                chkPovtorenie.Visible = false; // Убираем с глаз элемент управления
                numericLength.Enabled = false; // Отключаем элемент управления
                numericSegmentCount.Enabled = true; // Отключаем выбор количества сегментов
                numericSegmentSize.Enabled = true; // Отключаем выбор размера сегмента
                numericLength.Visible = false; // Убираем с глаз элемент управления
                numericSegmentCount.Visible = true; // Возвращаем элемент управления на экран
                numericSegmentSize.Visible = true; // Возвращаем элемент управления на экран
                label8.Text = "Длина:"; // Меняем текст на указанный
                numericLength.Location = new Point(numericSegmentCount.Location.X, numericSegmentCount.Location.Y); // Меняю местами numericSegmentCount и numericLength
                numericSegmentCount.Location = new Point(numericLength.Location.X, numericLength.Location.Y); // Меняю местами numericSegmentCount и numericLength
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}