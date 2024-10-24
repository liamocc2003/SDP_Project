using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSYS.Application_Frontend
{
    public class toolStripMenu
    {
        public toolStripMenu(MenuStrip menuStrip1)
        {
            var mnuMembers = new ToolStripMenuItem();
            var mnuRegisterMember = new ToolStripMenuItem();
            var mnuUpdateMember = new ToolStripMenuItem();
            var mnuTopUpMemberWallet = new ToolStripMenuItem();
            var classesToolStripMenuItem = new ToolStripMenuItem();
            var scheduleClassToolStripMenuItem = new ToolStripMenuItem();
            var updateClassToolStripMenuItem = new ToolStripMenuItem();
            var cancelClassToolStripMenuItem = new ToolStripMenuItem();
            var bookingsToolStripMenuItem = new ToolStripMenuItem();
            var makeBookingToolStripMenuItem = new ToolStripMenuItem();
            var cancelBookingToolStripMenuItem = new ToolStripMenuItem();
            var analysisToolStripMenuItem = new ToolStripMenuItem();
            var yearlyRevenueAnalysisToolStripMenuItem = new ToolStripMenuItem();
            var yearlyClassAnalysisToolStripMenuItem = new ToolStripMenuItem();

            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] {
                mnuMembers,
                classesToolStripMenuItem,
                bookingsToolStripMenuItem,
                analysisToolStripMenuItem
            });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(834, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuMembers
            // 
            mnuMembers.DropDownItems.AddRange(new ToolStripItem[] {
                mnuRegisterMember,
                mnuUpdateMember,
                mnuTopUpMemberWallet
            });
            mnuMembers.Name = "mnuMembers";
            mnuMembers.Size = new System.Drawing.Size(69, 20);
            mnuMembers.Text = "Members";
            // 
            // mnuRegisterMember
            // 
            mnuRegisterMember.Name = "mnuRegisterMember";
            mnuRegisterMember.Size = new System.Drawing.Size(196, 22);
            mnuRegisterMember.Text = "Register Member";
            mnuRegisterMember.Click += new System.EventHandler(mnuRegisterMember_Click);
            void mnuRegisterMember_Click(object sender, EventArgs e)
            {
                frmRegisterMember registerMember = new frmRegisterMember();
                registerMember.ShowDialog();
            }

            // 
            // mnuUpdateMember
            // 
            mnuUpdateMember.Name = "mnuUpdateMember";
            mnuUpdateMember.Size = new System.Drawing.Size(196, 22);
            mnuUpdateMember.Text = "Update Member";
            mnuUpdateMember.Click += new System.EventHandler(mnuUpdateMember_Click);
            void mnuUpdateMember_Click(object sender, EventArgs e)
            {
                frmUpdateMember updateMember = new frmUpdateMember();
                updateMember.Show();
            }
            // 
            // mnuTopUpMemberWallet
            // 
            mnuTopUpMemberWallet.Name = "mnuTopUpMemberWallet";
            mnuTopUpMemberWallet.Size = new System.Drawing.Size(196, 22);
            mnuTopUpMemberWallet.Text = "Top-up Member Wallet";
            mnuTopUpMemberWallet.Click += new System.EventHandler(mnuTopUpMemberWallet_Click);
            void mnuTopUpMemberWallet_Click(object sender, EventArgs e)
            {
                frmTopUpMemberWallet topUpMember = new frmTopUpMemberWallet();
                topUpMember.Show();
            }

            // 
            // classesToolStripMenuItem
            // 
            classesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                scheduleClassToolStripMenuItem,
                updateClassToolStripMenuItem,
                cancelClassToolStripMenuItem
            });
            classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            classesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            classesToolStripMenuItem.Text = "Classes";
            // 
            // scheduleClassToolStripMenuItem
            // 
            scheduleClassToolStripMenuItem.Name = "scheduleClassToolStripMenuItem";
            scheduleClassToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            scheduleClassToolStripMenuItem.Text = "Schedule Class";
            scheduleClassToolStripMenuItem.Click += new System.EventHandler(scheduleClassToolStripMenuItem_Click);
            void scheduleClassToolStripMenuItem_Click(object sender, EventArgs e)
            {
                frmScheduleClass scheduleClass = new frmScheduleClass();
                scheduleClass.Show();
            }
            // 
            // updateClassToolStripMenuItem
            // 
            updateClassToolStripMenuItem.Name = "updateClassToolStripMenuItem";
            updateClassToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            updateClassToolStripMenuItem.Text = "Update Class";
            updateClassToolStripMenuItem.Click += new System.EventHandler(updateClassToolStripMenuItem_Click);
            void updateClassToolStripMenuItem_Click(object sender, EventArgs e)
            {
                frmUpdateClass updateClass = new frmUpdateClass();
                updateClass.Show();
            }
            // 
            // cancelClassToolStripMenuItem
            // 
            cancelClassToolStripMenuItem.Name = "cancelClassToolStripMenuItem";
            cancelClassToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            cancelClassToolStripMenuItem.Text = "Cancel Class";
            cancelClassToolStripMenuItem.Click += new System.EventHandler(cancelClassToolStripMenuItem_Click);
            void cancelClassToolStripMenuItem_Click(object sender, EventArgs e)
            {
                frmCancelClass cancelClass = new frmCancelClass();
                cancelClass.Show();
            }

            // 
            // bookingsToolStripMenuItem
            // 
            bookingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                makeBookingToolStripMenuItem,
                cancelBookingToolStripMenuItem
            });
            bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            bookingsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            bookingsToolStripMenuItem.Text = "Bookings";
            // 
            // makeBookingToolStripMenuItem
            // 
            makeBookingToolStripMenuItem.Name = "makeBookingToolStripMenuItem";
            makeBookingToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            makeBookingToolStripMenuItem.Text = "Make Booking";
            makeBookingToolStripMenuItem.Click += new System.EventHandler(makeBookingToolStripMenuItem_Click);
            void makeBookingToolStripMenuItem_Click(object sender, EventArgs e)
            {
                frmMakeBooking makeBooking = new frmMakeBooking();
                makeBooking.Show();
            }
            // 
            // cancelBookingToolStripMenuItem
            // 
            cancelBookingToolStripMenuItem.Name = "cancelBookingToolStripMenuItem";
            cancelBookingToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            cancelBookingToolStripMenuItem.Text = "Cancel Booking";
            cancelBookingToolStripMenuItem.Click += new System.EventHandler(cancelBookingToolStripMenuItem_Click);
            void cancelBookingToolStripMenuItem_Click(object sender, EventArgs e)
            {
                frmCancelBooking cancelBooking = new frmCancelBooking();
                cancelBooking.Show();
            }

            // 
            // analysisToolStripMenuItem
            // 
            analysisToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                yearlyRevenueAnalysisToolStripMenuItem,
                yearlyClassAnalysisToolStripMenuItem
            });
            analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            analysisToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            analysisToolStripMenuItem.Text = "Analysis";
            // 
            // yearlyRevenueAnalysisToolStripMenuItem
            // 
            yearlyRevenueAnalysisToolStripMenuItem.Name = "yearlyRevenueAnalysisToolStripMenuItem";
            yearlyRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            yearlyRevenueAnalysisToolStripMenuItem.Text = "Yearly Revenue Analysis";
            yearlyRevenueAnalysisToolStripMenuItem.Click += new System.EventHandler(yearlyRevenueAnalysisToolStripMenuItem_Click);
            void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
            {
                frmYearlyRevenueAnalysis yearlyRevenueAnalysis = new frmYearlyRevenueAnalysis();
                yearlyRevenueAnalysis.Show();
            }
            // 
            // yearlyClassAnalysisToolStripMenuItem
            // 
            yearlyClassAnalysisToolStripMenuItem.Name = "yearlyClassAnalysisToolStripMenuItem";
            yearlyClassAnalysisToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            yearlyClassAnalysisToolStripMenuItem.Text = "Yearly Class Analysis";
            yearlyClassAnalysisToolStripMenuItem.Click += new System.EventHandler(yearlyClassAnalysisToolStripMenuItem_Click_1);
            void yearlyClassAnalysisToolStripMenuItem_Click_1(object sender, EventArgs e)
            {
                frmYearlyClassAnalysis yearlyClassAnalysis = new frmYearlyClassAnalysis();
                yearlyClassAnalysis.Show();
            }
        }
    }
}
