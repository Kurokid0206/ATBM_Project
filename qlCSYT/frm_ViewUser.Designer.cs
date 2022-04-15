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
            this.DataGridViewUser = new System.Windows.Forms.DataGridView();
            this.FakeConsole = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewUser
            // 
            this.DataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewUser.Location = new System.Drawing.Point(-3, -3);
            this.DataGridViewUser.Name = "DataGridViewUser";
            this.DataGridViewUser.RowHeadersWidth = 51;
            this.DataGridViewUser.RowTemplate.Height = 24;
            this.DataGridViewUser.Size = new System.Drawing.Size(494, 276);
            this.DataGridViewUser.TabIndex = 0;
            //this.DataGridViewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUser_CellContentClick);
            // 
            // FakeConsole
            // 
            this.FakeConsole.Location = new System.Drawing.Point(12, 376);
            this.FakeConsole.Multiline = true;
            this.FakeConsole.Name = "FakeConsole";
            this.FakeConsole.Size = new System.Drawing.Size(479, 62);
            this.FakeConsole.TabIndex = 1;
            // 
            // frm_ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FakeConsole);
            this.Controls.Add(this.DataGridViewUser);
            this.Name = "frm_ViewUser";
            this.Text = "View User";
            this.Load += new System.EventHandler(this.frm_ViewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewUser;
        private TextBox FakeConsole;
    }
}