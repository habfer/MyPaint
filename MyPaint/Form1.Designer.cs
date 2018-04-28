namespace MyPaint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.RadioPanel = new System.Windows.Forms.Panel();
            this.Triangle = new System.Windows.Forms.RadioButton();
            this.Circle = new System.Windows.Forms.RadioButton();
            this.Ellipse = new System.Windows.Forms.RadioButton();
            this.Square = new System.Windows.Forms.RadioButton();
            this.Rectangle = new System.Windows.Forms.RadioButton();
            this.Line = new System.Windows.Forms.RadioButton();
            this.Selecting = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.DrawAllBtn = new System.Windows.Forms.Button();
            this.RadioPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RadioPanel
            // 
            this.RadioPanel.Controls.Add(this.Triangle);
            this.RadioPanel.Controls.Add(this.Circle);
            this.RadioPanel.Controls.Add(this.Ellipse);
            this.RadioPanel.Controls.Add(this.Square);
            this.RadioPanel.Controls.Add(this.Rectangle);
            this.RadioPanel.Controls.Add(this.Line);
            this.RadioPanel.Controls.Add(this.Selecting);
            this.RadioPanel.Location = new System.Drawing.Point(1, 0);
            this.RadioPanel.Name = "RadioPanel";
            this.RadioPanel.Size = new System.Drawing.Size(179, 186);
            this.RadioPanel.TabIndex = 0;
            // 
            // Triangle
            // 
            this.Triangle.AutoSize = true;
            this.Triangle.Location = new System.Drawing.Point(15, 156);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(90, 17);
            this.Triangle.TabIndex = 6;
            this.Triangle.TabStop = true;
            this.Triangle.Text = "Треугольник";
            this.Triangle.UseVisualStyleBackColor = true;
            // 
            // Circle
            // 
            this.Circle.AutoSize = true;
            this.Circle.Location = new System.Drawing.Point(15, 133);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(48, 17);
            this.Circle.TabIndex = 5;
            this.Circle.TabStop = true;
            this.Circle.Text = "Круг";
            this.Circle.UseVisualStyleBackColor = true;
            // 
            // Ellipse
            // 
            this.Ellipse.AutoSize = true;
            this.Ellipse.Location = new System.Drawing.Point(15, 110);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(62, 17);
            this.Ellipse.TabIndex = 4;
            this.Ellipse.TabStop = true;
            this.Ellipse.Text = "Эллипс";
            this.Ellipse.UseVisualStyleBackColor = true;
            // 
            // Square
            // 
            this.Square.AutoSize = true;
            this.Square.Location = new System.Drawing.Point(15, 87);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(67, 17);
            this.Square.TabIndex = 3;
            this.Square.TabStop = true;
            this.Square.Text = "Квадрат";
            this.Square.UseVisualStyleBackColor = true;
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.Location = new System.Drawing.Point(15, 64);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(105, 17);
            this.Rectangle.TabIndex = 2;
            this.Rectangle.TabStop = true;
            this.Rectangle.Text = "Прямоугольник";
            this.Rectangle.UseVisualStyleBackColor = true;
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Location = new System.Drawing.Point(15, 41);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(57, 17);
            this.Line.TabIndex = 1;
            this.Line.TabStop = true;
            this.Line.Text = "Линия";
            this.Line.UseVisualStyleBackColor = true;
            // 
            // Selecting
            // 
            this.Selecting.AutoSize = true;
            this.Selecting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Selecting.Location = new System.Drawing.Point(11, 9);
            this.Selecting.Name = "Selecting";
            this.Selecting.Size = new System.Drawing.Size(134, 20);
            this.Selecting.TabIndex = 1;
            this.Selecting.Text = "Выбрать фигуру";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(105, 192);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 1;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(186, 9);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(960, 607);
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            // 
            // DrawAllBtn
            // 
            this.DrawAllBtn.Location = new System.Drawing.Point(3, 192);
            this.DrawAllBtn.Name = "DrawAllBtn";
            this.DrawAllBtn.Size = new System.Drawing.Size(75, 23);
            this.DrawAllBtn.TabIndex = 3;
            this.DrawAllBtn.Text = "Все фигуры";
            this.DrawAllBtn.UseVisualStyleBackColor = true;
            this.DrawAllBtn.Click += new System.EventHandler(this.DrawAllBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 636);
            this.Controls.Add(this.DrawAllBtn);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.RadioPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "MyPaint";
            this.RadioPanel.ResumeLayout(false);
            this.RadioPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RadioPanel;
        private System.Windows.Forms.Label Selecting;
        private System.Windows.Forms.RadioButton Line;
        private System.Windows.Forms.RadioButton Ellipse;
        private System.Windows.Forms.RadioButton Square;
        private System.Windows.Forms.RadioButton Rectangle;
        private System.Windows.Forms.RadioButton Triangle;
        private System.Windows.Forms.RadioButton Circle;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button DrawAllBtn;
    }
}

