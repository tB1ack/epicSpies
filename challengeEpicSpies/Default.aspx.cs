using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            previousAssignmentEndCalendar.SelectedDate = DateTime.Now.Date;
            newAssignmentStartCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
            newAssignmentEndCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);

        }

    }

    protected void assignSpyButton_Click(object sender, EventArgs e)
    {
        /*
        DateTime previousAssignmentEndDate = previousAssignmentEndCalendar.SelectedDate;
        DateTime newAssignmentStartDate = newAssignmentStartCalendar.SelectedDate;
        DateTime newAssignmentEndDate = newAssignmentEndCalendar.SelectedDate;

        TimeSpan timeOff = newAssignmentStartDate.Subtract(previousAssignmentEndDate);
        TimeSpan assignmentLength = newAssignmentEndDate.Subtract(newAssignmentStartDate);
        */

        double timeOffDuration = newAssignmentStartCalendar.SelectedDate.Subtract(previousAssignmentEndCalendar.SelectedDate).TotalDays;
        double assignmentDuration = newAssignmentEndCalendar.SelectedDate.Subtract(newAssignmentStartCalendar.SelectedDate).TotalDays;

        int budgetTotal = (int)assignmentDuration * 500;
        
        if (assignmentDuration > 21)
        {
            budgetTotal += 1000;
        };
        
        if (timeOffDuration < 14)
        {
            messageLabel.Text = "Error: Must allow at least two weeks between previous assignment and new assignment.";
            newAssignmentStartCalendar.SelectedDate = previousAssignmentEndCalendar.SelectedDate.AddDays(14);
            newAssignmentEndCalendar.SelectedDate = previousAssignmentEndCalendar.SelectedDate.AddDays(21);
        }
        else
        {
            messageLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. Budget total: {2:C}.", spyCodeNameTextBox.Text, assignmentNameTextBox.Text, budgetTotal);
        };
    }
}