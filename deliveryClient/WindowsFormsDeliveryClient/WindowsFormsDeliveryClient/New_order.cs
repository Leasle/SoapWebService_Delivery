using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDeliveryClient.ItemReference;
using WindowsFormsDeliveryClient.OrderReference;
using WindowsFormsDeliveryClient.ClientReference;

namespace WindowsFormsDeliveryClient
{
    public partial class loaderrbt : Form
    {
        public loaderrbt()
        {
            InitializeComponent();
        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            OrderServiceClient orderSoapClient = new OrderServiceClient();
            ItemServiceClient itemSoapClient = new ItemServiceClient();
            ClientServiceClient clientSoapClient = new ClientServiceClient();

            OrderReference.Client client = new OrderReference.Client();
            client.Name = this.nameClienttb.Text;
            client.PhoneNumber = this.phoneNumbertb.Text;

            OrderReference.Item item1 = new OrderReference.Item();
            item1.NameItem = this.nameItem1tb.Text;
            item1.Length = Double.Parse(this.length1tb.Text);
            item1.Width = Double.Parse(this.width1tb.Text);
            item1.Height = Double.Parse(this.height1tb.Text);
            item1.Weight = Double.Parse(this.weight1tb.Text);

            OrderReference.Item item2 = new OrderReference.Item();
            item2.NameItem = this.nameItem1tb.Text;
            item2.Length = Double.Parse(this.length2tb.Text);
            item2.Width = Double.Parse(this.width2tb.Text);
            item2.Height = Double.Parse(this.height2tb.Text);
            item2.Weight = Double.Parse(this.weight2tb.Text);

            List<OrderReference.Item> items = new List<OrderReference.Item>();
            items.Add(item1);
            items.Add(item2);

            OrderReference.Order order = new OrderReference.Order();
            order.Date = this.datetb.Text;
            order.Address = this.addresstb.Text;
            order.Loader = this.loader.Checked;
            order.Client = client;
            order.Items = items.ToArray();

            List<OrderReference.Order> orders = new List<OrderReference.Order>();
            orders.Add(order);

            client.Orders = orders.ToArray();

            item1.Order = order;
            item2.Order = order;

            try
            {
                //clientSoapClient.AddClient((ClientReference.Client)client);

                orderSoapClient.AddOrder(order);

                //itemSoapClient.AddItem((ItemReference.Item) item1);
                //itemSoapClient.AddItem((ItemReference.Item) item2);
            }
            catch (Exception error)
            {
                System.Diagnostics.Debug.Write("Error is occur " + error);
            }
        }
    }
}
