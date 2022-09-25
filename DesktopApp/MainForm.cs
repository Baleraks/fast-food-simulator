using DesktopApp.Services;

namespace DesktopApp
{
    public partial class MainForm : Form
    {
        private readonly Simulator _simulator;
     
        public new void Update()
        {
            this.Invoke(new Action (()=>lbCustomersOutput.Text = _simulator.NumberOfCustomersWaitingToPlaceOrder.ToString()));
            this.Invoke(new Action(() => lbPrepOrderOutput.Text = _simulator.CurrentOrder));
            this.Invoke(new Action(() => lbAvailableOrderOutput.Text = _simulator.ContOfCurrentlyAvailableOrders.ToString()));
            this.Invoke(new Action(() => lbReadyToCookOutput.Text = _simulator.CountOfWaitingOrders.ToString()));
            this.Invoke(new Action(() => lbWaitingCustomersOutput.Text = _simulator.CountOfWaitingCustomers.ToString()));
            this.Invoke(new Action(() => lbOrderOutput.Text = _simulator.CurrentOrderTakerOrder));
            
        }


        public MainForm()
        {
            InitializeComponent();
            _simulator = new Simulator(this,3000, 2000,2000, 1500, 2000);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _simulator.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _simulator.IsSimulatorWorking = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }

        
    }
}