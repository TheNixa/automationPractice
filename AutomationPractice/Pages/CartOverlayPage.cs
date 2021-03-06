﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationPractice.Pages
{
    class CartOverlayPage
    {
        readonly IWebDriver driver;

        public By proceedToCheckout = By.ClassName("button-medium");

        public CartOverlayPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("layer_cart")));
        }
    }
}
