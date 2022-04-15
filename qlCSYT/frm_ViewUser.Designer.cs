using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlCSYT.SqlConn;
using System.Data.Common;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using qlCSYT;

namespace qlCSYT
{
    partial class frm_ViewUser
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
            this.gv_User = new System.Windows.Forms.DataGridView();
            this.FakeConsole = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_User)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_User
            // 
            this.gv_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_User.Location = new System.Drawing.Point(-2, -2);
            this.gv_User.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gv_User.Name = "gv_User";
            this.gv_User.RowHeadersWidth = 51;
            this.gv_User.RowTemplate.Height = 24;
            this.gv_User.Size = new System.Drawing.Size(370, 224);
            this.gv_User.TabIndex = 0;
            // 
            // FakeConsole
            // 
            this.FakeConsole.Location = new System.Drawing.Point(9, 306);
            this.FakeConsole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FakeConsole.Multiline = true;
            this.FakeConsole.Name = "FakeConsole";
            this.FakeConsole.Size = new System.Drawing.Size(360, 51);
            this.FakeConsole.TabIndex = 1;
            // 
            // frm_ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.FakeConsole);
            this.Controls.Add(this.gv_User);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_ViewUser";
            this.Text = "View User";
            this.Load += new System.EventHandler(this.frm_ViewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_User;
        private TextBox FakeConsole;
    }
}