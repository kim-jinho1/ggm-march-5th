using LibGit2Sharp;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace GitGGM
{
    public partial class Clone : Form
    {
        string repoUrl = null;
        string localPath = null;
        private string _directory = null;


        public Clone()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Folderpath_TextChanged(object sender, EventArgs e)
        {
            Text = localPath;
        }

        private void Folderpath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "폴더를 선택하세요";
                folderBrowserDialog.ShowNewFolderButton = true;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    localPath = folderBrowserDialog.SelectedPath;
                    Folderpath.Text = localPath;
                }
            }
        }

        private void Clonebntn_Click(object sender, EventArgs e)
        {
            try
            {
                localPath = Path.Combine(localPath, FolderNameWrite.Text);
            }
            catch
            {
                MessageBox.Show("폴더이름을 입력하세요.");
            }

            if (Directory.Exists(localPath))
            {
                try
                {
                    Directory.Delete(localPath, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"기존 폴더 삭제 실패: {ex.Message}");
                    return;
                }
            }

            try
            {
                Repository.Clone(repoUrl, localPath);
                MessageBox.Show("클론 성공!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"클론 실패: {ex.Message}");
            }
        }

        private void URL_TextChanged(object sender, EventArgs e)
        {
            repoUrl = URL.Text;
        }

        private void Pushbtn_Click(object sender, EventArgs e)
        {
            PushChanges();
        }

        private void Commitbtn_Click(object sender, EventArgs e)
        {
            CommitChanges();
        }

        private void CommitChanges()
        {
            string commitMessage = txtCommitMessage.Text.Trim();
            if (string.IsNullOrWhiteSpace(commitMessage))
            {
                MessageBox.Show("커밋 메시지를 입력하세요.");
                return;
            }

            string directory = @"D:\C#\GitGGM\GitGGM";
            _directory = directory;
            // Git 저장소가 아니면 초기화
            if (!IsGitRepository(directory))
            {
                InitializeGitRepository(directory);
            }

            // 변경된 파일을 추가하고 커밋을 수행
            string addOutput = RunGitCommand(directory, "add .");
            if (!string.IsNullOrEmpty(addOutput))
            {
                MessageBox.Show("파일 추가 오류: " + addOutput);
                return;
            }

            string commitOutput = RunGitCommand(directory, $"commit -m \"{commitMessage}\"");
            if (string.IsNullOrEmpty(commitOutput))
            {
                MessageBox.Show("커밋 실패: 오류 발생");
                return;
            }

            MessageBox.Show("커밋 완료!");
        }

        private void PushChanges()
        {
            // 푸시 실행
            string pushOutput = RunGitCommand(_directory, "push origin main");
            if (string.IsNullOrEmpty(pushOutput))
            {
                MessageBox.Show("푸시 실패! 서버 확인이 필요합니다.");
            }
            else
            {
                MessageBox.Show("푸시 완료!");
            }

            txtCommitMessage.Clear();
        }


        // Git 명령어 실행 함수
        private string RunGitCommand(string directory, string args)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "git",
                Arguments = args,
                WorkingDirectory = directory,  // 작업할 디렉토리 지정
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = psi })
            {
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                if (!string.IsNullOrEmpty(error))
                {
                    return "Error: " + error;
                }
                return output;
            }
        }

        // Git 저장소 여부 확인
        private bool IsGitRepository(string directory)
        {
            string gitCheckOutput = RunGitCommand(directory, "rev-parse --is-inside-work-tree");
            return gitCheckOutput.Trim() == "true";
        }

        // Git 저장소 초기화
        private void InitializeGitRepository(string directory)
        {
            string initOutput = RunGitCommand(directory, "init");
            if (!string.IsNullOrEmpty(initOutput))
            {
                MessageBox.Show("Git 저장소 초기화 실패: " + initOutput);
            }
            else
            {
                MessageBox.Show("Git 저장소가 초기화되었습니다.");
            }
        }

        private void FolderNameWrite_TextChanged(object sender, EventArgs e)
        {

        }
    }
}