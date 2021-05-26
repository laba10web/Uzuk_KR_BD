namespace Uzuk_Affiche
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.data_poster = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.data_theatre = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.data_play = new System.Windows.Forms.DataGridView();
            this.playBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.afficheDataSet = new Uzuk_Affiche.afficheDataSet();
            this.posterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theatreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.posterTableAdapter = new Uzuk_Affiche.afficheDataSetTableAdapters.posterTableAdapter();
            this.playTableAdapter = new Uzuk_Affiche.afficheDataSetTableAdapters.playTableAdapter();
            this.theatreTableAdapter = new Uzuk_Affiche.afficheDataSetTableAdapters.theatreTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_poster)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_theatre)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afficheDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theatreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 324);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.data_poster);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 295);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Афиша";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // data_poster
            // 
            this.data_poster.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.data_poster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_poster.Location = new System.Drawing.Point(3, 3);
            this.data_poster.Name = "data_poster";
            this.data_poster.RowHeadersWidth = 51;
            this.data_poster.RowTemplate.Height = 24;
            this.data_poster.Size = new System.Drawing.Size(762, 289);
            this.data_poster.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.data_theatre);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Театры";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // data_theatre
            // 
            this.data_theatre.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.data_theatre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_theatre.Location = new System.Drawing.Point(6, 3);
            this.data_theatre.Name = "data_theatre";
            this.data_theatre.RowHeadersWidth = 51;
            this.data_theatre.RowTemplate.Height = 24;
            this.data_theatre.Size = new System.Drawing.Size(759, 286);
            this.data_theatre.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.data_play);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Спектакли";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // data_play
            // 
            this.data_play.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.data_play.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_play.Location = new System.Drawing.Point(3, 3);
            this.data_play.Name = "data_play";
            this.data_play.RowHeadersWidth = 51;
            this.data_play.RowTemplate.Height = 24;
            this.data_play.Size = new System.Drawing.Size(762, 289);
            this.data_play.TabIndex = 0;
            // 
            // playBindingSource
            // 
            this.playBindingSource.DataMember = "play";
            this.playBindingSource.DataSource = this.afficheDataSet;
            // 
            // afficheDataSet
            // 
            this.afficheDataSet.DataSetName = "afficheDataSet";
            this.afficheDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // posterBindingSource
            // 
            this.posterBindingSource.DataMember = "poster";
            this.posterBindingSource.DataSource = this.afficheDataSet;
            // 
            // theatreBindingSource
            // 
            this.theatreBindingSource.DataMember = "theatre";
            this.theatreBindingSource.DataSource = this.afficheDataSet;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(414, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Справочник по жанрам";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(192, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(16, 437);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(337, 54);
            this.button4.TabIndex = 4;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(623, 361);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 54);
            this.button5.TabIndex = 5;
            this.button5.Text = "Поиск";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(414, 374);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 30);
            this.textBox1.TabIndex = 6;
            // 
            // posterTableAdapter
            // 
            this.posterTableAdapter.ClearBeforeFill = true;
            // 
            // playTableAdapter
            // 
            this.playTableAdapter.ClearBeforeFill = true;
            // 
            // theatreTableAdapter
            // 
            this.theatreTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Афиша";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_poster)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_theatre)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afficheDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theatreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView data_poster;
        private System.Windows.Forms.DataGridView data_theatre;
        private System.Windows.Forms.DataGridView data_play;
        private afficheDataSet afficheDataSet;
        private System.Windows.Forms.BindingSource posterBindingSource;
        private afficheDataSetTableAdapters.posterTableAdapter posterTableAdapter;
        private System.Windows.Forms.BindingSource playBindingSource;
        private afficheDataSetTableAdapters.playTableAdapter playTableAdapter;
        private System.Windows.Forms.BindingSource theatreBindingSource;
        private afficheDataSetTableAdapters.theatreTableAdapter theatreTableAdapter;
    }
}