namespace _05_zanrovi_knjiga
{
    partial class BooksFrm
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
            this.dgvGenre = new System.Windows.Forms.DataGridView();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbOfPages = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMainAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGenre
            // 
            this.dgvGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenre.Location = new System.Drawing.Point(30, 27);
            this.dgvGenre.Name = "dgvGenre";
            this.dgvGenre.RowHeadersWidth = 51;
            this.dgvGenre.RowTemplate.Height = 24;
            this.dgvGenre.Size = new System.Drawing.Size(384, 222);
            this.dgvGenre.TabIndex = 0;
            this.dgvGenre.SelectionChanged += new System.EventHandler(this.dgvGenre_SelectionChanged);
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(29, 292);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(725, 162);
            this.dgvBooks.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddBook);
            this.groupBox1.Controls.Add(this.tbOfPages);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(454, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 222);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Books";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(21, 57);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(127, 22);
            this.tbTitle.TabIndex = 1;
            // 
            // tbOfPages
            // 
            this.tbOfPages.Location = new System.Drawing.Point(21, 121);
            this.tbOfPages.Name = "tbOfPages";
            this.tbOfPages.Size = new System.Drawing.Size(127, 22);
            this.tbOfPages.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "# of pages";
            // 
            // tbMainAuthor
            // 
            this.tbMainAuthor.Location = new System.Drawing.Point(475, 212);
            this.tbMainAuthor.Name = "tbMainAuthor";
            this.tbMainAuthor.Size = new System.Drawing.Size(127, 22);
            this.tbMainAuthor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Main author";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(169, 56);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(112, 23);
            this.btnAddBook.TabIndex = 4;
            this.btnAddBook.Text = "AddBook";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(635, 460);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(119, 23);
            this.btnDeleteBook.TabIndex = 5;
            this.btnDeleteBook.Text = "DeleteBook";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Books";
            // 
            // BooksFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.tbMainAuthor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.dgvGenre);
            this.Name = "BooksFrm";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.BooksFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGenre;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox tbOfPages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMainAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

