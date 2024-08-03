namespace WinApp_postgresql_backup
{
    partial class Form_pgBackup
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_db_name = new System.Windows.Forms.TextBox();
            this.textBox_db_port = new System.Windows.Forms.TextBox();
            this.textBox_db_host = new System.Windows.Forms.TextBox();
            this.textBox_db_pass = new System.Windows.Forms.TextBox();
            this.textBox_db_user = new System.Windows.Forms.TextBox();
            this.textBox_restorePath = new System.Windows.Forms.TextBox();
            this.textBox_dumpPath = new System.Windows.Forms.TextBox();
            this.textBox_dbPath = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_passfile = new System.Windows.Forms.Button();
            this.button_pg_dump_cmd = new System.Windows.Forms.Button();
            this.button_pg_restore_cmd = new System.Windows.Forms.Button();
            this.button_open_passfile_folder = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.checkBox_showpass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_dumpDir = new System.Windows.Forms.Button();
            this.button_restoreFile = new System.Windows.Forms.Button();
            this.button_pg_bin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_db_name
            // 
            this.textBox_db_name.AllowDrop = true;
            this.textBox_db_name.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_db_name.Location = new System.Drawing.Point(169, 148);
            this.textBox_db_name.Name = "textBox_db_name";
            this.textBox_db_name.Size = new System.Drawing.Size(347, 28);
            this.textBox_db_name.TabIndex = 5;
            this.textBox_db_name.Text = "db name";
            this.toolTip1.SetToolTip(this.textBox_db_name, "redmineのインストールパス");
            // 
            // textBox_db_port
            // 
            this.textBox_db_port.AllowDrop = true;
            this.textBox_db_port.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_db_port.Location = new System.Drawing.Point(169, 114);
            this.textBox_db_port.Name = "textBox_db_port";
            this.textBox_db_port.Size = new System.Drawing.Size(347, 28);
            this.textBox_db_port.TabIndex = 4;
            this.textBox_db_port.Text = "db port";
            this.toolTip1.SetToolTip(this.textBox_db_port, "redmineのインストールパス");
            // 
            // textBox_db_host
            // 
            this.textBox_db_host.AllowDrop = true;
            this.textBox_db_host.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_db_host.Location = new System.Drawing.Point(169, 80);
            this.textBox_db_host.Name = "textBox_db_host";
            this.textBox_db_host.Size = new System.Drawing.Size(347, 28);
            this.textBox_db_host.TabIndex = 3;
            this.textBox_db_host.Text = "db host";
            this.toolTip1.SetToolTip(this.textBox_db_host, "redmineのインストールパス");
            // 
            // textBox_db_pass
            // 
            this.textBox_db_pass.AllowDrop = true;
            this.textBox_db_pass.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_db_pass.Location = new System.Drawing.Point(169, 46);
            this.textBox_db_pass.Name = "textBox_db_pass";
            this.textBox_db_pass.PasswordChar = '*';
            this.textBox_db_pass.Size = new System.Drawing.Size(347, 28);
            this.textBox_db_pass.TabIndex = 1;
            this.textBox_db_pass.Text = "db pass";
            this.toolTip1.SetToolTip(this.textBox_db_pass, "redmineのインストールパス");
            // 
            // textBox_db_user
            // 
            this.textBox_db_user.AllowDrop = true;
            this.textBox_db_user.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_db_user.Location = new System.Drawing.Point(169, 12);
            this.textBox_db_user.Name = "textBox_db_user";
            this.textBox_db_user.Size = new System.Drawing.Size(347, 28);
            this.textBox_db_user.TabIndex = 0;
            this.textBox_db_user.Text = "db user";
            this.toolTip1.SetToolTip(this.textBox_db_user, "redmineのインストールパス");
            // 
            // textBox_restorePath
            // 
            this.textBox_restorePath.AllowDrop = true;
            this.textBox_restorePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_restorePath.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_restorePath.Location = new System.Drawing.Point(16, 480);
            this.textBox_restorePath.Name = "textBox_restorePath";
            this.textBox_restorePath.Size = new System.Drawing.Size(584, 28);
            this.textBox_restorePath.TabIndex = 13;
            this.textBox_restorePath.Text = "restore path (file)";
            this.toolTip1.SetToolTip(this.textBox_restorePath, "リストアするバックアップファイル\r\n");
            // 
            // textBox_dumpPath
            // 
            this.textBox_dumpPath.AllowDrop = true;
            this.textBox_dumpPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_dumpPath.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_dumpPath.Location = new System.Drawing.Point(16, 348);
            this.textBox_dumpPath.Name = "textBox_dumpPath";
            this.textBox_dumpPath.Size = new System.Drawing.Size(584, 28);
            this.textBox_dumpPath.TabIndex = 10;
            this.textBox_dumpPath.Text = "dump dir path (dir)";
            this.toolTip1.SetToolTip(this.textBox_dumpPath, "バックアップファイルを出力するディレクトリ\r\n");
            // 
            // textBox_dbPath
            // 
            this.textBox_dbPath.AllowDrop = true;
            this.textBox_dbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_dbPath.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_dbPath.Location = new System.Drawing.Point(16, 282);
            this.textBox_dbPath.Name = "textBox_dbPath";
            this.textBox_dbPath.Size = new System.Drawing.Size(584, 28);
            this.textBox_dbPath.TabIndex = 8;
            this.textBox_dbPath.Text = "db install path (dir)";
            this.toolTip1.SetToolTip(this.textBox_dbPath, "pg_dump,pg_restoreの存在するディレクトリ\r\n");
            // 
            // button_passfile
            // 
            this.button_passfile.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_passfile.Location = new System.Drawing.Point(169, 182);
            this.button_passfile.Name = "button_passfile";
            this.button_passfile.Size = new System.Drawing.Size(220, 50);
            this.button_passfile.TabIndex = 6;
            this.button_passfile.Text = "パスワードファイルの生成";
            this.toolTip1.SetToolTip(this.button_passfile, "コマンド中のパスワード入力を省略するパスワードファイルを設定します");
            this.button_passfile.UseVisualStyleBackColor = true;
            // 
            // button_pg_dump_cmd
            // 
            this.button_pg_dump_cmd.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_pg_dump_cmd.Location = new System.Drawing.Point(169, 382);
            this.button_pg_dump_cmd.Name = "button_pg_dump_cmd";
            this.button_pg_dump_cmd.Size = new System.Drawing.Size(220, 50);
            this.button_pg_dump_cmd.TabIndex = 12;
            this.button_pg_dump_cmd.Text = "バックアップの実行";
            this.button_pg_dump_cmd.UseVisualStyleBackColor = true;
            // 
            // button_pg_restore_cmd
            // 
            this.button_pg_restore_cmd.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_pg_restore_cmd.Location = new System.Drawing.Point(169, 514);
            this.button_pg_restore_cmd.Name = "button_pg_restore_cmd";
            this.button_pg_restore_cmd.Size = new System.Drawing.Size(220, 50);
            this.button_pg_restore_cmd.TabIndex = 15;
            this.button_pg_restore_cmd.Text = "リストアの実行";
            this.button_pg_restore_cmd.UseVisualStyleBackColor = true;
            // 
            // button_open_passfile_folder
            // 
            this.button_open_passfile_folder.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_open_passfile_folder.Location = new System.Drawing.Point(396, 182);
            this.button_open_passfile_folder.Name = "button_open_passfile_folder";
            this.button_open_passfile_folder.Size = new System.Drawing.Size(220, 50);
            this.button_open_passfile_folder.TabIndex = 7;
            this.button_open_passfile_folder.Text = "パスワードファイルの確認";
            this.toolTip1.SetToolTip(this.button_open_passfile_folder, "パスワードファイルの配置先を表示します");
            this.button_open_passfile_folder.UseVisualStyleBackColor = true;
            // 
            // button_load
            // 
            this.button_load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_load.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_load.Location = new System.Drawing.Point(516, 612);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(120, 50);
            this.button_load.TabIndex = 17;
            this.button_load.Text = "設定復元";
            this.button_load.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_save.Location = new System.Drawing.Point(390, 612);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(120, 50);
            this.button_save.TabIndex = 16;
            this.button_save.Text = "設定保存";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // checkBox_showpass
            // 
            this.checkBox_showpass.AutoSize = true;
            this.checkBox_showpass.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_showpass.Location = new System.Drawing.Point(522, 49);
            this.checkBox_showpass.Name = "checkBox_showpass";
            this.checkBox_showpass.Size = new System.Drawing.Size(71, 25);
            this.checkBox_showpass.TabIndex = 2;
            this.checkBox_showpass.Text = "表示";
            this.checkBox_showpass.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "ユーザー：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "パスワード：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "ホスト名/IP：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 49;
            this.label4.Text = "ポート：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 50;
            this.label5.Text = "データベース：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(12, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(424, 21);
            this.label6.TabIndex = 51;
            this.label6.Text = "PostgreSQL binディレクトリ（pg_dump,pg_restore）";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(12, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 21);
            this.label7.TabIndex = 52;
            this.label7.Text = "ダンプファイルの出力先ディレクトリ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(12, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 21);
            this.label8.TabIndex = 53;
            this.label8.Text = "リストアするダンプファイル";
            // 
            // button_dumpDir
            // 
            this.button_dumpDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_dumpDir.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_dumpDir.Location = new System.Drawing.Point(606, 346);
            this.button_dumpDir.Name = "button_dumpDir";
            this.button_dumpDir.Size = new System.Drawing.Size(30, 30);
            this.button_dumpDir.TabIndex = 11;
            this.button_dumpDir.Text = "...";
            this.button_dumpDir.UseVisualStyleBackColor = true;
            // 
            // button_restoreFile
            // 
            this.button_restoreFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_restoreFile.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_restoreFile.Location = new System.Drawing.Point(606, 478);
            this.button_restoreFile.Name = "button_restoreFile";
            this.button_restoreFile.Size = new System.Drawing.Size(30, 30);
            this.button_restoreFile.TabIndex = 14;
            this.button_restoreFile.Text = "...";
            this.button_restoreFile.UseVisualStyleBackColor = true;
            // 
            // button_pg_bin
            // 
            this.button_pg_bin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_pg_bin.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_pg_bin.Location = new System.Drawing.Point(606, 280);
            this.button_pg_bin.Name = "button_pg_bin";
            this.button_pg_bin.Size = new System.Drawing.Size(30, 30);
            this.button_pg_bin.TabIndex = 9;
            this.button_pg_bin.Text = "...";
            this.button_pg_bin.UseVisualStyleBackColor = true;
            // 
            // Form_pgBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 674);
            this.Controls.Add(this.button_pg_bin);
            this.Controls.Add(this.button_restoreFile);
            this.Controls.Add(this.button_dumpDir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_open_passfile_folder);
            this.Controls.Add(this.button_pg_restore_cmd);
            this.Controls.Add(this.button_pg_dump_cmd);
            this.Controls.Add(this.checkBox_showpass);
            this.Controls.Add(this.textBox_db_name);
            this.Controls.Add(this.textBox_db_port);
            this.Controls.Add(this.textBox_db_host);
            this.Controls.Add(this.textBox_db_pass);
            this.Controls.Add(this.textBox_db_user);
            this.Controls.Add(this.textBox_restorePath);
            this.Controls.Add(this.textBox_dumpPath);
            this.Controls.Add(this.textBox_dbPath);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_passfile);
            this.Name = "Form_pgBackup";
            this.Text = "PostgreSQLバックアップ・リストア";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_db_name;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox_db_port;
        private System.Windows.Forms.TextBox textBox_db_host;
        private System.Windows.Forms.TextBox textBox_db_pass;
        private System.Windows.Forms.TextBox textBox_db_user;
        private System.Windows.Forms.TextBox textBox_restorePath;
        private System.Windows.Forms.TextBox textBox_dumpPath;
        private System.Windows.Forms.TextBox textBox_dbPath;
        private System.Windows.Forms.Button button_passfile;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.CheckBox checkBox_showpass;
        private System.Windows.Forms.Button button_pg_dump_cmd;
        private System.Windows.Forms.Button button_pg_restore_cmd;
        private System.Windows.Forms.Button button_open_passfile_folder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_dumpDir;
        private System.Windows.Forms.Button button_restoreFile;
        private System.Windows.Forms.Button button_pg_bin;
    }
}

