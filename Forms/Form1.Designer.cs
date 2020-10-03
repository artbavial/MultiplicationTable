namespace MultiplicationTable
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.txtbox_answer = new System.Windows.Forms.TextBox();
            this.label_X = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this._labelx = new System.Windows.Forms.Label();
            this._label_equally = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelShowInfo = new System.Windows.Forms.Label();
            this.linkLabel_aboutApp = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timerSecondomer = new System.Windows.Forms.Timer(this.components);
            this.label_timer = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label_points = new System.Windows.Forms.Label();
            this.label_hints = new System.Windows.Forms.Label();
            this.label_errors = new System.Windows.Forms.Label();
            this._label1 = new System.Windows.Forms.Label();
            this._label2 = new System.Windows.Forms.Label();
            this._label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbox_answer
            // 
            this.txtbox_answer.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_answer.Location = new System.Drawing.Point(246, 86);
            this.txtbox_answer.MaxLength = 2;
            this.txtbox_answer.Name = "txtbox_answer";
            this.txtbox_answer.Size = new System.Drawing.Size(100, 38);
            this.txtbox_answer.TabIndex = 0;
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_X.Location = new System.Drawing.Point(47, 90);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(33, 34);
            this.label_X.TabIndex = 1;
            this.label_X.Text = "X";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.Location = new System.Drawing.Point(162, 90);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(31, 34);
            this.labelY.TabIndex = 2;
            this.labelY.Text = "Y";
            // 
            // _labelx
            // 
            this._labelx.AutoSize = true;
            this._labelx.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelx.Location = new System.Drawing.Point(108, 91);
            this._labelx.Name = "_labelx";
            this._labelx.Size = new System.Drawing.Size(24, 27);
            this._labelx.TabIndex = 3;
            this._labelx.Text = "x";
            // 
            // _label_equally
            // 
            this._label_equally.AutoSize = true;
            this._label_equally.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label_equally.Location = new System.Drawing.Point(216, 92);
            this._label_equally.Name = "_label_equally";
            this._label_equally.Size = new System.Drawing.Size(27, 27);
            this._label_equally.TabIndex = 4;
            this._label_equally.Text = "=";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.Green;
            this.btnOk.Location = new System.Drawing.Point(246, 179);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 52);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(136, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelShowInfo);
            this.panel1.Location = new System.Drawing.Point(-2, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 33);
            this.panel1.TabIndex = 7;
            // 
            // labelShowInfo
            // 
            this.labelShowInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowInfo.Location = new System.Drawing.Point(14, 2);
            this.labelShowInfo.Name = "labelShowInfo";
            this.labelShowInfo.Size = new System.Drawing.Size(361, 29);
            this.labelShowInfo.TabIndex = 0;
            this.labelShowInfo.Text = "Добро пожаловать в тренажер таблицы умножения!";
            this.labelShowInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel_aboutApp
            // 
            this.linkLabel_aboutApp.AutoSize = true;
            this.linkLabel_aboutApp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_aboutApp.Location = new System.Drawing.Point(12, 254);
            this.linkLabel_aboutApp.Name = "linkLabel_aboutApp";
            this.linkLabel_aboutApp.Size = new System.Drawing.Size(116, 20);
            this.linkLabel_aboutApp.TabIndex = 8;
            this.linkLabel_aboutApp.TabStop = true;
            this.linkLabel_aboutApp.Text = "О программе";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this._label3);
            this.panel2.Controls.Add(this._label2);
            this.panel2.Controls.Add(this._label1);
            this.panel2.Controls.Add(this.label_errors);
            this.panel2.Controls.Add(this.label_hints);
            this.panel2.Controls.Add(this.label_points);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 61);
            this.panel2.TabIndex = 9;
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer.Location = new System.Drawing.Point(303, 255);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(70, 21);
            this.label_timer.TabIndex = 10;
            this.label_timer.Text = "##.##.##";
            // 
            // button_refresh
            // 
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ForeColor = System.Drawing.Color.Red;
            this.button_refresh.Location = new System.Drawing.Point(32, 179);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 52);
            this.button_refresh.TabIndex = 11;
            this.button_refresh.Text = "↻";
            this.button_refresh.UseVisualStyleBackColor = true;
            // 
            // label_points
            // 
            this.label_points.BackColor = System.Drawing.Color.Green;
            this.label_points.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_points.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_points.Location = new System.Drawing.Point(19, 9);
            this.label_points.Name = "label_points";
            this.label_points.Size = new System.Drawing.Size(75, 28);
            this.label_points.TabIndex = 0;
            this.label_points.Text = "0";
            this.label_points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_hints
            // 
            this.label_hints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_hints.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hints.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_hints.Location = new System.Drawing.Point(140, 9);
            this.label_hints.Name = "label_hints";
            this.label_hints.Size = new System.Drawing.Size(75, 28);
            this.label_hints.TabIndex = 1;
            this.label_hints.Text = "0";
            this.label_hints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_errors
            // 
            this.label_errors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_errors.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_errors.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_errors.Location = new System.Drawing.Point(258, 9);
            this.label_errors.Name = "label_errors";
            this.label_errors.Size = new System.Drawing.Size(75, 28);
            this.label_errors.TabIndex = 2;
            this.label_errors.Text = "0";
            this.label_errors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _label1
            // 
            this._label1.AutoSize = true;
            this._label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label1.Location = new System.Drawing.Point(36, 40);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(47, 16);
            this._label1.TabIndex = 3;
            this._label1.Text = "очков";
            // 
            // _label2
            // 
            this._label2.AutoSize = true;
            this._label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label2.Location = new System.Drawing.Point(140, 40);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(77, 16);
            this._label2.TabIndex = 12;
            this._label2.Text = "подсказок";
            // 
            // _label3
            // 
            this._label3.AutoSize = true;
            this._label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label3.Location = new System.Drawing.Point(268, 40);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(56, 16);
            this._label3.TabIndex = 13;
            this._label3.Text = "ошибок";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 283);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.label_timer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.linkLabel_aboutApp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this._label_equally);
            this.Controls.Add(this._labelx);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.txtbox_answer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тренажер таблицы умножения";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_answer;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label _labelx;
        private System.Windows.Forms.Label _label_equally;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelShowInfo;
        private System.Windows.Forms.LinkLabel linkLabel_aboutApp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timerSecondomer;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label _label3;
        private System.Windows.Forms.Label _label2;
        private System.Windows.Forms.Label _label1;
        private System.Windows.Forms.Label label_errors;
        private System.Windows.Forms.Label label_hints;
        private System.Windows.Forms.Label label_points;
    }
}

