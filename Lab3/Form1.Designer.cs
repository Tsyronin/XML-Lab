namespace Lab3
{
    partial class MenuWindow
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
            this.OutputTable = new System.Windows.Forms.RichTextBox();
            this.CuisineCheckBox = new System.Windows.Forms.CheckBox();
            this.CourseCheckBox = new System.Windows.Forms.CheckBox();
            this.WeightCheckBox = new System.Windows.Forms.CheckBox();
            this.DescriptionCheckBox = new System.Windows.Forms.CheckBox();
            this.DishBox = new System.Windows.Forms.ComboBox();
            this.CuisineBox = new System.Windows.Forms.ComboBox();
            this.CourseBox = new System.Windows.Forms.ComboBox();
            this.WeightBox = new System.Windows.Forms.ComboBox();
            this.DescriptionBox = new System.Windows.Forms.ComboBox();
            this.DOM = new System.Windows.Forms.RadioButton();
            this.SAX = new System.Windows.Forms.RadioButton();
            this.LINQ = new System.Windows.Forms.RadioButton();
            this.Search = new System.Windows.Forms.Button();
            this.ToHTML = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.DishCheckBox = new System.Windows.Forms.CheckBox();
            this.PriceCheckBox = new System.Windows.Forms.CheckBox();
            this.PriceBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // OutputTable
            // 
            this.OutputTable.Location = new System.Drawing.Point(225, 17);
            this.OutputTable.Name = "OutputTable";
            this.OutputTable.Size = new System.Drawing.Size(298, 312);
            this.OutputTable.TabIndex = 0;
            this.OutputTable.Text = "";
            // 
            // CuisineCheckBox
            // 
            this.CuisineCheckBox.AutoSize = true;
            this.CuisineCheckBox.Location = new System.Drawing.Point(12, 53);
            this.CuisineCheckBox.Name = "CuisineCheckBox";
            this.CuisineCheckBox.Size = new System.Drawing.Size(60, 17);
            this.CuisineCheckBox.TabIndex = 2;
            this.CuisineCheckBox.Text = "Cuisine";
            this.CuisineCheckBox.UseVisualStyleBackColor = true;
            this.CuisineCheckBox.CheckedChanged += new System.EventHandler(this.CuisineCheckBox_CheckedChanged);
            // 
            // CourseCheckBox
            // 
            this.CourseCheckBox.AutoSize = true;
            this.CourseCheckBox.Location = new System.Drawing.Point(12, 85);
            this.CourseCheckBox.Name = "CourseCheckBox";
            this.CourseCheckBox.Size = new System.Drawing.Size(59, 17);
            this.CourseCheckBox.TabIndex = 4;
            this.CourseCheckBox.Text = "Course";
            this.CourseCheckBox.UseVisualStyleBackColor = true;
            this.CourseCheckBox.CheckedChanged += new System.EventHandler(this.CourseCheckBox_CheckedChanged);
            // 
            // WeightCheckBox
            // 
            this.WeightCheckBox.AutoSize = true;
            this.WeightCheckBox.Location = new System.Drawing.Point(12, 117);
            this.WeightCheckBox.Name = "WeightCheckBox";
            this.WeightCheckBox.Size = new System.Drawing.Size(60, 17);
            this.WeightCheckBox.TabIndex = 5;
            this.WeightCheckBox.Text = "Weight";
            this.WeightCheckBox.UseVisualStyleBackColor = true;
            this.WeightCheckBox.CheckedChanged += new System.EventHandler(this.WeightCheckBox_CheckedChanged);
            // 
            // DescriptionCheckBox
            // 
            this.DescriptionCheckBox.AutoSize = true;
            this.DescriptionCheckBox.Location = new System.Drawing.Point(12, 149);
            this.DescriptionCheckBox.Name = "DescriptionCheckBox";
            this.DescriptionCheckBox.Size = new System.Drawing.Size(79, 17);
            this.DescriptionCheckBox.TabIndex = 6;
            this.DescriptionCheckBox.Text = "Description";
            this.DescriptionCheckBox.UseVisualStyleBackColor = true;
            this.DescriptionCheckBox.CheckedChanged += new System.EventHandler(this.DescriptionCheckBox_CheckedChanged);
            // 
            // DishBox
            // 
            this.DishBox.FormattingEnabled = true;
            this.DishBox.Location = new System.Drawing.Point(98, 17);
            this.DishBox.Name = "DishBox";
            this.DishBox.Size = new System.Drawing.Size(121, 21);
            this.DishBox.TabIndex = 7;
            // 
            // CuisineBox
            // 
            this.CuisineBox.FormattingEnabled = true;
            this.CuisineBox.Location = new System.Drawing.Point(98, 49);
            this.CuisineBox.Name = "CuisineBox";
            this.CuisineBox.Size = new System.Drawing.Size(121, 21);
            this.CuisineBox.TabIndex = 8;
            // 
            // CourseBox
            // 
            this.CourseBox.FormattingEnabled = true;
            this.CourseBox.Location = new System.Drawing.Point(98, 81);
            this.CourseBox.Name = "CourseBox";
            this.CourseBox.Size = new System.Drawing.Size(121, 21);
            this.CourseBox.TabIndex = 9;
            // 
            // WeightBox
            // 
            this.WeightBox.FormattingEnabled = true;
            this.WeightBox.Location = new System.Drawing.Point(98, 113);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(121, 21);
            this.WeightBox.TabIndex = 10;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.FormattingEnabled = true;
            this.DescriptionBox.Location = new System.Drawing.Point(98, 145);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(121, 21);
            this.DescriptionBox.TabIndex = 11;
            // 
            // DOM
            // 
            this.DOM.AutoSize = true;
            this.DOM.Location = new System.Drawing.Point(12, 222);
            this.DOM.Name = "DOM";
            this.DOM.Size = new System.Drawing.Size(50, 17);
            this.DOM.TabIndex = 12;
            this.DOM.TabStop = true;
            this.DOM.Text = "DOM";
            this.DOM.UseVisualStyleBackColor = true;
            // 
            // SAX
            // 
            this.SAX.AutoSize = true;
            this.SAX.Location = new System.Drawing.Point(12, 246);
            this.SAX.Name = "SAX";
            this.SAX.Size = new System.Drawing.Size(46, 17);
            this.SAX.TabIndex = 13;
            this.SAX.TabStop = true;
            this.SAX.Text = "SAX";
            this.SAX.UseVisualStyleBackColor = true;
            // 
            // LINQ
            // 
            this.LINQ.AutoSize = true;
            this.LINQ.Location = new System.Drawing.Point(13, 270);
            this.LINQ.Name = "LINQ";
            this.LINQ.Size = new System.Drawing.Size(50, 17);
            this.LINQ.TabIndex = 14;
            this.LINQ.TabStop = true;
            this.LINQ.Text = "LINQ";
            this.LINQ.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(98, 222);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(121, 65);
            this.Search.TabIndex = 15;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // ToHTML
            // 
            this.ToHTML.Location = new System.Drawing.Point(18, 293);
            this.ToHTML.Name = "ToHTML";
            this.ToHTML.Size = new System.Drawing.Size(63, 36);
            this.ToHTML.TabIndex = 16;
            this.ToHTML.Text = "To HTML";
            this.ToHTML.UseVisualStyleBackColor = true;
            this.ToHTML.Click += new System.EventHandler(this.ToHTML_Click);
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(87, 293);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(63, 36);
            this.Info.TabIndex = 17;
            this.Info.Text = "Info";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(156, 293);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(63, 36);
            this.Clear.TabIndex = 18;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // DishCheckBox
            // 
            this.DishCheckBox.AutoSize = true;
            this.DishCheckBox.Location = new System.Drawing.Point(13, 20);
            this.DishCheckBox.Name = "DishCheckBox";
            this.DishCheckBox.Size = new System.Drawing.Size(47, 17);
            this.DishCheckBox.TabIndex = 19;
            this.DishCheckBox.Text = "Dish";
            this.DishCheckBox.UseVisualStyleBackColor = true;
            this.DishCheckBox.CheckedChanged += new System.EventHandler(this.DishCheckBox_CheckedChanged);
            // 
            // PriceCheckBox
            // 
            this.PriceCheckBox.AutoSize = true;
            this.PriceCheckBox.Location = new System.Drawing.Point(12, 181);
            this.PriceCheckBox.Name = "PriceCheckBox";
            this.PriceCheckBox.Size = new System.Drawing.Size(50, 17);
            this.PriceCheckBox.TabIndex = 20;
            this.PriceCheckBox.Text = "Price";
            this.PriceCheckBox.UseVisualStyleBackColor = true;
            this.PriceCheckBox.CheckedChanged += new System.EventHandler(this.PriceCheckBox_CheckedChanged);
            // 
            // PriceBox
            // 
            this.PriceBox.FormattingEnabled = true;
            this.PriceBox.Location = new System.Drawing.Point(98, 177);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(121, 21);
            this.PriceBox.TabIndex = 21;
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 340);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.PriceCheckBox);
            this.Controls.Add(this.DishCheckBox);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.ToHTML);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.LINQ);
            this.Controls.Add(this.SAX);
            this.Controls.Add(this.DOM);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.WeightBox);
            this.Controls.Add(this.CourseBox);
            this.Controls.Add(this.CuisineBox);
            this.Controls.Add(this.DishBox);
            this.Controls.Add(this.DescriptionCheckBox);
            this.Controls.Add(this.WeightCheckBox);
            this.Controls.Add(this.CourseCheckBox);
            this.Controls.Add(this.CuisineCheckBox);
            this.Controls.Add(this.OutputTable);
            this.Name = "MenuWindow";
            this.Text = "Menu@Tsyronin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuWindow_FormClosing);
            this.Load += new System.EventHandler(this.MenuWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox OutputTable;
        private System.Windows.Forms.CheckBox CuisineCheckBox;
        private System.Windows.Forms.CheckBox CourseCheckBox;
        private System.Windows.Forms.CheckBox WeightCheckBox;
        private System.Windows.Forms.CheckBox DescriptionCheckBox;
        private System.Windows.Forms.ComboBox DishBox;
        private System.Windows.Forms.ComboBox CuisineBox;
        private System.Windows.Forms.ComboBox CourseBox;
        private System.Windows.Forms.ComboBox WeightBox;
        private System.Windows.Forms.ComboBox DescriptionBox;
        private System.Windows.Forms.RadioButton DOM;
        private System.Windows.Forms.RadioButton SAX;
        private System.Windows.Forms.RadioButton LINQ;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button ToHTML;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.CheckBox DishCheckBox;
        private System.Windows.Forms.CheckBox PriceCheckBox;
        private System.Windows.Forms.ComboBox PriceBox;
    }
}

