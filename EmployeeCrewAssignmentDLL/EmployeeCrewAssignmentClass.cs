/* Title:           Employee Crew Assignment Class
 * Date:            2-7-18
 * Author:          Terry Holmes
 * 
 * Description:     This the class for Employee Crew Assignment*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace EmployeeCrewAssignmentDLL
{
    public class EmployeeCrewAssignmentClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        EmployeeCrewAssignmentDataSet aEmployeeCrewAssignmentDataSet;
        EmployeeCrewAssignmentDataSetTableAdapters.employeecrewassignmentTableAdapter aEmployeeCrewAssignmentTableAdapter;

        InsertEmployeeCrewAssignmentEntryTableAdapters.QueriesTableAdapter aInsertEmployeeCrewAssignmentTableAdapter;

        UpdateEmployeeCrewAssignmentEntryTableAdapters.QueriesTableAdapter aUpdateEmployeeCrewAssignmentTableAdapter;

        FindEmployeeCrewAssignmentByDateRangeDataSet aFindEmployeeCrewAssignmentByDateRangeDataSet;
        FindEmployeeCrewAssignmentByDateRangeDataSetTableAdapters.FindEmployeeCrewAssignmentByDateRangeTableAdapter aFindEmployeeCrewAssignmentByDateRangeTableAdapter;

        FindEmployeeCrewByCrewIDDataSet aFindEmployeeCrewByCrewIDDataSet;
        FindEmployeeCrewByCrewIDDataSetTableAdapters.FindEmployeeCrewByCrewIDTableAdapter aFindEmployeeCrewByCrewIDTableAdapter;

        FindEmployeeCrewsByDateRangeDataSet aFindEmployeeCrewsByDateRangeDataSet;
        FindEmployeeCrewsByDateRangeDataSetTableAdapters.FindEmployeeCrewsByDateRangeTableAdapter aFindEmployeeCrewsByDateRangeTableAdapter;

        FindCrewProductivityForATaskDataSet aFindCrewProductivityForATaskDataSet;
        FindCrewProductivityForATaskDataSetTableAdapters.FindCrewProductivtyForATaskTableAdapter aFindCrewProductivityForATaskTableAdapter;

        FindEmployeeCrewAssignmentComboBoxDataSet aFindEmployeeCrewAssignmentComboBoxDataSet;
        FindEmployeeCrewAssignmentComboBoxDataSetTableAdapters.FindEmployeeCrewAssignmentComboBoxTableAdapter aFindEmployeeCrewAssignmentComboBoxTableAdapter;

        FindDetailedEmployeeCrewAssignmentByCrewIDDataSet aFindDetailedEmployeeCrewAssignmentByCrewIDDataSet;
        FindDetailedEmployeeCrewAssignmentByCrewIDDataSetTableAdapters.FindDetailedEmployeeCrewAssignmentByCrewIDTableAdapter aFindDetailedEmployeeCrewAssignmentByCrewIDTableAdapter;

        FindEmployeeCrewAssignmentProductionDataSet aFindEmployeeCrewAssignmentProductionDataSet;
        FindEmployeeCrewAssignmentProductionDataSetTableAdapters.FindEmployeeCrewAssignmentProductionTableAdapter aFindEmployeeCrewAssignmentProductionTableAdapter;

        public FindEmployeeCrewAssignmentProductionDataSet FindEmployeeCrewAssignmentProduction(string strCrewID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindEmployeeCrewAssignmentProductionDataSet = new FindEmployeeCrewAssignmentProductionDataSet();
                aFindEmployeeCrewAssignmentProductionTableAdapter = new FindEmployeeCrewAssignmentProductionDataSetTableAdapters.FindEmployeeCrewAssignmentProductionTableAdapter();
                aFindEmployeeCrewAssignmentProductionTableAdapter.Fill(aFindEmployeeCrewAssignmentProductionDataSet.FindEmployeeCrewAssignmentProduction, strCrewID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Crew Assignment Class // Find Detailed Employee Crew Assignment Production " + Ex.ToString());
            }

            return aFindEmployeeCrewAssignmentProductionDataSet;
        }
        public FindDetailedEmployeeCrewAssignmentByCrewIDDataSet FindDetailedEmployeeCrewAssignmentByCrewID(string strCrewID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDetailedEmployeeCrewAssignmentByCrewIDDataSet = new FindDetailedEmployeeCrewAssignmentByCrewIDDataSet();
                aFindDetailedEmployeeCrewAssignmentByCrewIDTableAdapter = new FindDetailedEmployeeCrewAssignmentByCrewIDDataSetTableAdapters.FindDetailedEmployeeCrewAssignmentByCrewIDTableAdapter();
                aFindDetailedEmployeeCrewAssignmentByCrewIDTableAdapter.Fill(aFindDetailedEmployeeCrewAssignmentByCrewIDDataSet.FindDetailedEmployeeCrewAssignmentByCrewID, strCrewID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Crew Assignment Class // Find Detailed Employee Crew Assignment by Crew ID " + Ex.ToString());
            }

            return aFindDetailedEmployeeCrewAssignmentByCrewIDDataSet;
        }
        public FindEmployeeCrewAssignmentComboBoxDataSet FindEmployeeCrewAssignmentComboBox(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindEmployeeCrewAssignmentComboBoxDataSet = new FindEmployeeCrewAssignmentComboBoxDataSet();
                aFindEmployeeCrewAssignmentComboBoxTableAdapter = new FindEmployeeCrewAssignmentComboBoxDataSetTableAdapters.FindEmployeeCrewAssignmentComboBoxTableAdapter();
                aFindEmployeeCrewAssignmentComboBoxTableAdapter.Fill(aFindEmployeeCrewAssignmentComboBoxDataSet.FindEmployeeCrewAssignmentComboBox, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Crew Assignment Class // Find Employee Crew Assignment Combo Box " + Ex.ToString());
            }

            return aFindEmployeeCrewAssignmentComboBoxDataSet;
        }
        public FindCrewProductivityForATaskDataSet FindCrewProductivityForATask(int intProjectID, int intTaskID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindCrewProductivityForATaskDataSet = new FindCrewProductivityForATaskDataSet();
                aFindCrewProductivityForATaskTableAdapter = new FindCrewProductivityForATaskDataSetTableAdapters.FindCrewProductivtyForATaskTableAdapter();
                aFindCrewProductivityForATaskTableAdapter.Fill(aFindCrewProductivityForATaskDataSet.FindCrewProductivtyForATask, intProjectID, intTaskID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Crew Assignment Class // Find Crew Productivity For a Task " + Ex.ToString());
            }

            return aFindCrewProductivityForATaskDataSet;
        }
        public FindEmployeeCrewsByDateRangeDataSet FindEmployeeCrewsByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindEmployeeCrewsByDateRangeDataSet = new FindEmployeeCrewsByDateRangeDataSet();
                aFindEmployeeCrewsByDateRangeTableAdapter = new FindEmployeeCrewsByDateRangeDataSetTableAdapters.FindEmployeeCrewsByDateRangeTableAdapter();
                aFindEmployeeCrewsByDateRangeTableAdapter.Fill(aFindEmployeeCrewsByDateRangeDataSet.FindEmployeeCrewsByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Crew Assignment Class // Find Employee Crews By Date Range " + Ex.ToString());
            }

            return aFindEmployeeCrewsByDateRangeDataSet;
        }
        public FindEmployeeCrewByCrewIDDataSet FindEmployeeCrewByCrewID(string strCrewID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindEmployeeCrewByCrewIDDataSet = new FindEmployeeCrewByCrewIDDataSet();
                aFindEmployeeCrewByCrewIDTableAdapter = new FindEmployeeCrewByCrewIDDataSetTableAdapters.FindEmployeeCrewByCrewIDTableAdapter();
                aFindEmployeeCrewByCrewIDTableAdapter.Fill(aFindEmployeeCrewByCrewIDDataSet.FindEmployeeCrewByCrewID, strCrewID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Crew Assignment Class // Find Employee Crew By Crew ID " + Ex.ToString());
            }

            return aFindEmployeeCrewByCrewIDDataSet;
        }
        public FindEmployeeCrewAssignmentByDateRangeDataSet FindEmployeeCrewAssignmentByDateRange(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindEmployeeCrewAssignmentByDateRangeDataSet = new FindEmployeeCrewAssignmentByDateRangeDataSet();
                aFindEmployeeCrewAssignmentByDateRangeTableAdapter = new FindEmployeeCrewAssignmentByDateRangeDataSetTableAdapters.FindEmployeeCrewAssignmentByDateRangeTableAdapter();
                aFindEmployeeCrewAssignmentByDateRangeTableAdapter.Fill(aFindEmployeeCrewAssignmentByDateRangeDataSet.FindEmployeeCrewAssignmentByDateRange, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Crew Assignment Class // Find Employee Crew Assignment By Date Range " + Ex.ToString());
            }

            return aFindEmployeeCrewAssignmentByDateRangeDataSet;
        }
        public bool UpdateEmployeeCrewAssignment(int intTransactionID, string strCrewID, int intEmployeeID, int intProjectID, DateTime datTransactionDate)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateEmployeeCrewAssignmentTableAdapter = new UpdateEmployeeCrewAssignmentEntryTableAdapters.QueriesTableAdapter();
                aUpdateEmployeeCrewAssignmentTableAdapter.UpdateEmployeeCrewAssignment(intTransactionID, strCrewID, intEmployeeID, intProjectID, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Crew Assignment Class // Update Employee Crew Assignment " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertEmployeeCrewAssignment(string strCrewID, int intEmployeeID, int intProjectID, DateTime datTransactionDate)
        {
            bool blnFatalError = false;

            try
            {
                aInsertEmployeeCrewAssignmentTableAdapter = new InsertEmployeeCrewAssignmentEntryTableAdapters.QueriesTableAdapter();
                aInsertEmployeeCrewAssignmentTableAdapter.InsertEmployeeCrewAssignment(strCrewID, intEmployeeID, intProjectID, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Crew Assignment Class // Insert Employee Crew Assignment " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public EmployeeCrewAssignmentDataSet GetEmployeeCrewAssignmentInfo()
        {
            try
            {
                aEmployeeCrewAssignmentDataSet = new EmployeeCrewAssignmentDataSet();
                aEmployeeCrewAssignmentTableAdapter = new EmployeeCrewAssignmentDataSetTableAdapters.employeecrewassignmentTableAdapter();
                aEmployeeCrewAssignmentTableAdapter.Fill(aEmployeeCrewAssignmentDataSet.employeecrewassignment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Crew Assignment Class // Get Employee Crew Info " + Ex.ToString());
            }

            return aEmployeeCrewAssignmentDataSet;
        }
        public void UpdateEmployeeCrewAssignmentDB(EmployeeCrewAssignmentDataSet aEmployeeCrewAssignmentDataSet)
        {
            try
            {
                aEmployeeCrewAssignmentTableAdapter = new EmployeeCrewAssignmentDataSetTableAdapters.employeecrewassignmentTableAdapter();
                aEmployeeCrewAssignmentTableAdapter.Update(aEmployeeCrewAssignmentDataSet.employeecrewassignment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Crew Assignment Class // Update Employee Crew DB " + Ex.ToString());
            }
        }
    }
}
