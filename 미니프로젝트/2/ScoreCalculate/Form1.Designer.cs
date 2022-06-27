
namespace ScoreCalculate
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.start_btn = new System.Windows.Forms.Button();
            this.Title_tbox = new System.Windows.Forms.TextBox();
            this.main_view = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.샌즈1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.score_tbox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.school_tbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.name_tbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.main_view.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.Black;
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start_btn.Font = new System.Drawing.Font("둥근모꼴", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.start_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.start_btn.Location = new System.Drawing.Point(401, 350);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(242, 56);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "ENTER START";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            this.start_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.start_btn_KeyDown);
            this.start_btn.MouseLeave += new System.EventHandler(this.start_btn_MouseLeave);
            this.start_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.start_btn_MouseMove);
            // 
            // Title_tbox
            // 
            this.Title_tbox.BackColor = System.Drawing.Color.Black;
            this.Title_tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title_tbox.Font = new System.Drawing.Font("둥근모꼴", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title_tbox.ForeColor = System.Drawing.Color.White;
            this.Title_tbox.Location = new System.Drawing.Point(275, 86);
            this.Title_tbox.Multiline = true;
            this.Title_tbox.Name = "Title_tbox";
            this.Title_tbox.Size = new System.Drawing.Size(453, 194);
            this.Title_tbox.TabIndex = 1;
            this.Title_tbox.Text = "낙제를\r\n    향해..";
            // 
            // main_view
            // 
            this.main_view.AutoSize = true;
            this.main_view.Controls.Add(this.Title_tbox);
            this.main_view.Controls.Add(this.start_btn);
            this.main_view.Controls.Add(this.button1);
            this.main_view.Controls.Add(this.샌즈1);
            this.main_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_view.Location = new System.Drawing.Point(951, 509);
            this.main_view.Name = "main_view";
            this.main_view.Size = new System.Drawing.Size(986, 675);
            this.main_view.TabIndex = 3;
            this.main_view.TabStop = false;
            this.main_view.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(-30, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(464, 293);
            this.button1.TabIndex = 4;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // 샌즈1
            // 
            this.샌즈1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("샌즈1.BackgroundImage")));
            this.샌즈1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.샌즈1.Enabled = false;
            this.샌즈1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.샌즈1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.샌즈1.Location = new System.Drawing.Point(649, 328);
            this.샌즈1.Name = "샌즈1";
            this.샌즈1.Size = new System.Drawing.Size(297, 327);
            this.샌즈1.TabIndex = 4;
            this.샌즈1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(40, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 209);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.score_tbox);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.school_tbox);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.name_tbox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.line);
            this.panel2.Controls.Add(this.name_label);
            this.panel2.Location = new System.Drawing.Point(6, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 195);
            this.panel2.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(534, 79);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 50);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // score_tbox
            // 
            this.score_tbox.BackColor = System.Drawing.Color.Black;
            this.score_tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.score_tbox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.score_tbox.ForeColor = System.Drawing.SystemColors.Window;
            this.score_tbox.Location = new System.Drawing.Point(110, 141);
            this.score_tbox.Name = "score_tbox";
            this.score_tbox.Size = new System.Drawing.Size(138, 19);
            this.score_tbox.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(107, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 2);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // school_tbox
            // 
            this.school_tbox.BackColor = System.Drawing.Color.Black;
            this.school_tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.school_tbox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.school_tbox.ForeColor = System.Drawing.SystemColors.Window;
            this.school_tbox.Location = new System.Drawing.Point(110, 84);
            this.school_tbox.Name = "school_tbox";
            this.school_tbox.Size = new System.Drawing.Size(138, 19);
            this.school_tbox.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(107, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 2);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "점수 : ";
            // 
            // name_tbox
            // 
            this.name_tbox.BackColor = System.Drawing.Color.Black;
            this.name_tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_tbox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_tbox.ForeColor = System.Drawing.SystemColors.Window;
            this.name_tbox.Location = new System.Drawing.Point(110, 26);
            this.name_tbox.Name = "name_tbox";
            this.name_tbox.Size = new System.Drawing.Size(138, 19);
            this.name_tbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "학교 : ";
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.White;
            this.line.Enabled = false;
            this.line.Location = new System.Drawing.Point(107, 48);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(143, 2);
            this.line.TabIndex = 2;
            this.line.UseVisualStyleBackColor = false;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_label.ForeColor = System.Drawing.Color.White;
            this.name_label.Location = new System.Drawing.Point(17, 25);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(98, 27);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "이름 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.main_view);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "누가 낙제했니?";
            this.main_view.ResumeLayout(false);
            this.main_view.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.GroupBox main_view;
        private System.Windows.Forms.Button 샌즈1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.TextBox name_tbox;
        private System.Windows.Forms.TextBox score_tbox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox school_tbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Title_tbox;
    }
}

