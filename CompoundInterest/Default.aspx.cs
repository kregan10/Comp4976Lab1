﻿using System;
using CompoundInterestLibrary.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompoundInterest
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            FutureValue fv = new CompoundInterestLibrary.Models.FutureValue(principalInvestment.Text, 
                interestRate.Text, numOfCompoundsPerYear.Text, numOfYears.Text);
            lblResult.Text = Convert.ToString(fv.calcPresentValue());
        }
    }
}