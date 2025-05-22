using System.ComponentModel;

namespace WinFormsApp_20_Thread_Practice
{
    public partial class Form1 : Form
    {
        // #1. ��ü ����
        BackgroundWorker bcw = new BackgroundWorker();
        public Form1()
        {
            InitializeComponent();
            // #2. �ɼ� ����
            bcw.WorkerReportsProgress = true;

            // #3. ���α׷����� �⺻ �� ���� ���� (0 ~ 100)
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            // #8. �̺�Ʈ ����
            bcw.DoWork += Bcw_DoWork;
            bcw.ProgressChanged += Bcw_ProgressChanged;
            bcw.RunWorkerCompleted += Bcw_RunWorkerCompleted;

        }

        // #4. ��ư Ŭ�� ��, ��׶��� worker �۾��� ����!
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // ��׶��� �۾� ����!
            bcw.RunWorkerAsync();
        }

        // #5. DoWork�� ������ ���� �۾�
        private void Bcw_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(30);   // 30ms ����
                bcw.ReportProgress(i);  // ���� ��Ȳ ����
            }
        }

        // #6. UI ������(����)���� ���α׷����� ������Ʈ
        private void Bcw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        // #7. �۾� �Ϸ� �� �޽��� �ڽ� ���
        private void Bcw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("�Ϸ��");
        }
    }
}
