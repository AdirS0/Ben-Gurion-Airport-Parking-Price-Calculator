using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BenGurionAirportParkingPriceCalculator.CalculateStrategy;
using BenGurionAirportParkingPriceCalculator.Exceptions;

namespace BenGurionAirportParkingPriceCalculator
{
    public partial class FormBGAParkingPriceCalculator : Form
    {
        private CalculateParkingPrice calculateParkingPrice;
        private bool shortRange;
        private bool cover;
        private int terminal;

        public FormBGAParkingPriceCalculator()
        {
            InitializeComponent();
        }

        private void buttonShortRange_Click(object sender, EventArgs e)
        {
            buttonShortRange.BackColor = Color.LightGreen;
            buttonLongRange.BackColor = System.Drawing.SystemColors.Control;
            shortRange = true;

            hideLongRangeOptions();
            showShortRangeOptions();

            if (!shortRangeOptionWasClicked())
            {
                disableDatesLabelsAndCalculate();
            }
        }

        private void buttonLongRange_Click(object sender, EventArgs e)
        {
            buttonLongRange.BackColor = Color.LightGreen;
            buttonShortRange.BackColor = System.Drawing.SystemColors.Control;
            shortRange = false;

            hideShortRangeOptions();
            showLongRangeOptions();

            if (!longRangeOptionWasClicked())
            {
                disableDatesLabelsAndCalculate();
            }
        }

        private bool shortRangeOptionWasClicked()
        {
            bool clicked = true;

            if (buttonTerminalOne.BackColor != Color.LightGreen && buttonTerminalThree.BackColor != Color.LightGreen)
            {
                clicked = false;
            }

            return clicked;
        }

        private bool longRangeOptionWasClicked()
        {
            bool clicked = true;

            if (buttonWithCover.BackColor != Color.LightGreen && buttonWithoutCover.BackColor != Color.LightGreen)
            {
                clicked = false;
            }

            return clicked;
        }

        private void showShortRangeOptions()
        {
            buttonTerminalOne.Visible = true;
            buttonTerminalThree.Visible = true;
        }

        private void showLongRangeOptions()
        {
            buttonWithCover.Visible = true;
            buttonWithoutCover.Visible = true;
            labelWithCoverInfo.Visible = true;
        }

        private void hideShortRangeOptions()
        {
            buttonTerminalOne.Visible = false;
            buttonTerminalThree.Visible = false;
        }

        private void hideLongRangeOptions()
        {
            buttonWithCover.Visible = false;
            buttonWithoutCover.Visible = false;
            labelWithCoverInfo.Visible = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            resetAndHideControls();
            disableDatesLabelsAndCalculate();
            this.calculateParkingPrice = null;
        }

        private void resetAndHideControls()
        {
            hideShortRangeOptions();
            hideLongRangeOptions();

            var buttons = this.Controls.OfType<Button>();

            foreach (Button button in buttons)
            {
                button.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void buttonTerminalOne_Click(object sender, EventArgs e)
        {
            buttonTerminalOne.BackColor = Color.LightGreen;
            buttonTerminalThree.BackColor = System.Drawing.SystemColors.Control;
            terminal = 1;

            enableDatesLabelsAndCalculate();
        }

        private void buttonTerminalThree_Click(object sender, EventArgs e)
        {
            buttonTerminalThree.BackColor = Color.LightGreen;
            buttonTerminalOne.BackColor = System.Drawing.SystemColors.Control;
            terminal = 3;

            enableDatesLabelsAndCalculate();
        }

        private void buttonWithCover_Click(object sender, EventArgs e)
        {
            buttonWithCover.BackColor = Color.LightGreen;
            buttonWithoutCover.BackColor = System.Drawing.SystemColors.Control;
            cover = true;

            enableDatesLabelsAndCalculate();
        }

        private void buttonWithoutCover_Click(object sender, EventArgs e)
        {
            buttonWithoutCover.BackColor = Color.LightGreen;
            buttonWithCover.BackColor = System.Drawing.SystemColors.Control;
            cover = false;

            enableDatesLabelsAndCalculate();
        }

        private void enableDatesLabelsAndCalculate()
        {
            labelFrom.Enabled = true;
            labelTo.Enabled = true;
            labelDash.Enabled = true;
            dateTimePickerEndTime.Enabled = true;
            dateTimePickerStartTime.Enabled = true;
            buttonCalculate.Enabled = true;
        }

        private void disableDatesLabelsAndCalculate()
        {
            labelFrom.Enabled = false;
            labelTo.Enabled = false;
            labelDash.Enabled = false;
            dateTimePickerEndTime.Enabled = false;
            dateTimePickerStartTime.Enabled = false;
            buttonCalculate.Enabled = false;
        }

        private void validateStartDateEarlierThanEndDate()
        {
            if (dateTimePickerStartTime.Value > dateTimePickerEndTime.Value)
            {

                throw new InvalidDatesException();
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (shortRange)
            {
                ICalculateParkingPriceStrategy calculateStrategy = new CalculateShortRangePrice(terminal);
                this.calculateParkingPrice = new CalculateParkingPrice(calculateStrategy);
            }
            else
            {
                ICalculateParkingPriceStrategy calculateStrategy = new CalculateLongRangePrice(cover);
                this.calculateParkingPrice = new CalculateParkingPrice(calculateStrategy);
            }

            try
            {
                validateStartDateEarlierThanEndDate();

                DateTime startDate = dateTimePickerStartTime.Value;
                DateTime endDate = dateTimePickerEndTime.Value;
                int totalDays = (int)endDate.Subtract(startDate).TotalDays;
                int hours = (int)endDate.Subtract(startDate).Hours;
                int minutes = (int)endDate.Subtract(startDate).Minutes;

                int parkingPrice = this.calculateParkingPrice.Calculate(startDate, endDate);

                MessageBox.Show($@"For {totalDays} days, {hours} hours and {minutes} minutes
Your parking price will be {parkingPrice} shekels", "Price", MessageBoxButtons.OK);
            }
            catch (InvalidDatesException ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
