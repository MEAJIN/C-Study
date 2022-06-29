
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
            this.main_Panel = new System.Windows.Forms.GroupBox();
            this.calculate_Panel = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.샌즈1 = new System.Windows.Forms.Button();
            this.info_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.score_tbox = new System.Windows.Forms.TextBox();
            this.school_tbox = new System.Windows.Forms.TextBox();
            this.score_label = new System.Windows.Forms.Label();
            this.name_tbox = new System.Windows.Forms.TextBox();
            this.school_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.writeValue_tbox = new System.Windows.Forms.TextBox();
            this.main_Panel.SuspendLayout();
            this.calculate_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.info_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.Black;
            this.start_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            // main_Panel
            // 
            this.main_Panel.AutoSize = true;
            this.main_Panel.Controls.Add(this.calculate_Panel);
            this.main_Panel.Controls.Add(this.Title_tbox);
            this.main_Panel.Controls.Add(this.start_btn);
            this.main_Panel.Controls.Add(this.button1);
            this.main_Panel.Controls.Add(this.샌즈1);
            this.main_Panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_Panel.Location = new System.Drawing.Point(953, 528);
            this.main_Panel.Name = "main_Panel";
            this.main_Panel.Size = new System.Drawing.Size(1035, 675);
            this.main_Panel.TabIndex = 3;
            this.main_Panel.TabStop = false;
            this.main_Panel.Text = "groupBox1";
            // 
            // calculate_Panel
            // 
            this.calculate_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calculate_Panel.Controls.Add(this.dataGridView);
            this.calculate_Panel.Enabled = false;
            this.calculate_Panel.Location = new System.Drawing.Point(18, 20);
            this.calculate_Panel.Name = "calculate_Panel";
            this.calculate_Panel.Size = new System.Drawing.Size(991, 568);
            this.calculate_Panel.TabIndex = 6;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(15, 15);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(387, 259);
            this.dataGridView.TabIndex = 0;
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
            // info_panel
            // 
            this.info_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.info_panel.Controls.Add(this.label2);
            this.info_panel.Controls.Add(this.panel2);
            this.info_panel.Controls.Add(this.writeValue_tbox);
            this.info_panel.Location = new System.Drawing.Point(-4, -3);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(992, 567);
            this.info_panel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("둥근모꼴", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(49, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(44, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 209);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.score_tbox);
            this.panel3.Controls.Add(this.school_tbox);
            this.panel3.Controls.Add(this.score_label);
            this.panel3.Controls.Add(this.name_tbox);
            this.panel3.Controls.Add(this.school_label);
            this.panel3.Controls.Add(this.name_label);
            this.panel3.Location = new System.Drawing.Point(6, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(893, 195);
            this.panel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("둥근모꼴", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(778, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "↩ ENTER(입력)";
            // 
            // score_tbox
            // 
            this.score_tbox.BackColor = System.Drawing.Color.Black;
            this.score_tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.score_tbox.Font = new System.Drawing.Font("둥근모꼴", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.score_tbox.ForeColor = System.Drawing.SystemColors.Window;
            this.score_tbox.Location = new System.Drawing.Point(81, 145);
            this.score_tbox.Name = "score_tbox";
            this.score_tbox.Size = new System.Drawing.Size(140, 21);
            this.score_tbox.TabIndex = 3;
            this.score_tbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.score_tbox_KeyDown);
            this.score_tbox.MouseLeave += new System.EventHandler(this.score_tbox_MouseLeave);
            this.score_tbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.score_tbox_MouseMove);
            // 
            // school_tbox
            // 
            this.school_tbox.BackColor = System.Drawing.Color.Black;
            this.school_tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.school_tbox.Font = new System.Drawing.Font("둥근모꼴", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.school_tbox.ForeColor = System.Drawing.SystemColors.Window;
            this.school_tbox.Location = new System.Drawing.Point(80, 89);
            this.school_tbox.Name = "school_tbox";
            this.school_tbox.Size = new System.Drawing.Size(140, 21);
            this.school_tbox.TabIndex = 2;
            this.school_tbox.MouseLeave += new System.EventHandler(this.school_tbox_MouseLeave);
            this.school_tbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.school_tbox_MouseMove);
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("둥근모꼴", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.score_label.ForeColor = System.Drawing.Color.White;
            this.score_label.Location = new System.Drawing.Point(17, 145);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(74, 21);
            this.score_label.TabIndex = 0;
            this.score_label.Text = "점수: ";
            // 
            // name_tbox
            // 
            this.name_tbox.BackColor = System.Drawing.Color.Black;
            this.name_tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_tbox.Font = new System.Drawing.Font("둥근모꼴", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_tbox.ForeColor = System.Drawing.SystemColors.Window;
            this.name_tbox.Location = new System.Drawing.Point(79, 31);
            this.name_tbox.Name = "name_tbox";
            this.name_tbox.Size = new System.Drawing.Size(140, 21);
            this.name_tbox.TabIndex = 1;
            this.name_tbox.MouseLeave += new System.EventHandler(this.name_tbox_MouseLeave);
            this.name_tbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.name_tbox_MouseMove);
            // 
            // school_label
            // 
            this.school_label.AutoSize = true;
            this.school_label.Font = new System.Drawing.Font("둥근모꼴", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.school_label.ForeColor = System.Drawing.Color.White;
            this.school_label.Location = new System.Drawing.Point(17, 88);
            this.school_label.Name = "school_label";
            this.school_label.Size = new System.Drawing.Size(74, 21);
            this.school_label.TabIndex = 0;
            this.school_label.Text = "학교: ";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("둥근모꼴", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_label.ForeColor = System.Drawing.Color.White;
            this.name_label.Location = new System.Drawing.Point(17, 30);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(74, 21);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "이름: ";
            // 
            // writeValue_tbox
            // 
            this.writeValue_tbox.BackColor = System.Drawing.Color.Black;
            this.writeValue_tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.writeValue_tbox.Font = new System.Drawing.Font("둥근모꼴", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.writeValue_tbox.ForeColor = System.Drawing.Color.White;
            this.writeValue_tbox.Location = new System.Drawing.Point(56, 65);
            this.writeValue_tbox.Multiline = true;
            this.writeValue_tbox.Name = "writeValue_tbox";
            this.writeValue_tbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.writeValue_tbox.Size = new System.Drawing.Size(887, 230);
            this.writeValue_tbox.TabIndex = 14;
            this.writeValue_tbox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.info_panel);
            this.Controls.Add(this.main_Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "누가 낙제했니?";
            this.main_Panel.ResumeLayout(false);
            this.main_Panel.PerformLayout();
            this.calculate_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.info_panel.ResumeLayout(false);
            this.info_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.GroupBox main_Panel;
        private System.Windows.Forms.Button 샌즈1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Title_tbox;
        private System.Windows.Forms.Panel calculate_Panel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox score_tbox;
        private System.Windows.Forms.TextBox school_tbox;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.TextBox name_tbox;
        private System.Windows.Forms.Label school_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox writeValue_tbox;
    }
}

