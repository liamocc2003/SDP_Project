using GymSYS.Application_Frontend;
using Moq;
using NUnit.Framework;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSYS.Testing
{
    internal class Tests
    {
        [Test]
        public void MenuItem_Click_Should_Open_RegisterMemberForm()
        {
            var mockForm = new Mock<Form>();
            var mockMenuStrip = new MenuStrip();
            toolStripMenu menuStrip = new toolStripMenu(mockMenuStrip, mockForm.Object);

            var registerMemberItem = mockMenuStrip.Items
                .Cast<ToolStripMenuItem>()
                .FirstOrDefault(item => item.Text == "Register Member");

            
            registerMemberItem.PerformClick();


            mockForm.Verify(form => form.Hide(), Times.Once);
        }


        [Test]
        public void MenuStrip_Should_Have_All_Required_MenuItems()
        {
            var mockMenuStrip = new MenuStrip();
            var mockForm = new Form();
            toolStripMenu toolStripMenu = new toolStripMenu(mockMenuStrip, mockForm);


            var items = mockMenuStrip.Items.Cast<ToolStripMenuItem>();


            Assert.That(items.Any(item => item.Text == "Members"));
            Assert.That(items.Any(item => item.Text == "Classes"));
            Assert.That(items.Any(item => item.Text == "Bookings"));
        }
    }
}
