using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvpSurvivalKit.View;
using Moq;
using MvpSurvivalKit.Services;

namespace MvpSurvivalKit.Presentation.Tests
{
    [TestClass]
    public class CheckoutPresenterTests
    {
        /// <summary>
        /// This tests that for a valid session id the view properties are set correctly
        /// </summary>
        [TestMethod]
        public void InitializeWithValidSessionIdBindsCorrectViewProperties()
        {
            // Arrange
            Mock<ICheckoutView> mockView = new Mock<ICheckoutView>();
            mockView.Setup(v => v.SessionID).Returns("123");
            mockView.SetupSet(v => v.Products = It.Is<List<ProductItem>>(i => i.Count == 3)).Verifiable();
            mockView.SetupSet(v => v.Total = It.Is<decimal>(t => t == 8.97m)).Verifiable();
            mockView.SetupSet(v => v.SubTotal = It.Is<decimal>(t => t == 8.97m)).Verifiable();
            mockView.SetupSet(v => v.Discount = It.Is<decimal>(t => t == 0m)).Verifiable();

            Mock<INavigationService> mockNavigator = new Mock<INavigationService>();

            CheckoutPresenter presenter = new CheckoutPresenter(mockView.Object, mockNavigator.Object, GetCheckoutServiceStub());

            // Act
            presenter.Initialize();

            // Assert
            mockView.Verify();
        }

        // Gets a product service stub
        private static ICheckoutService GetCheckoutServiceStub()
        {
            Mock<ICheckoutService> stubService = new Mock<ICheckoutService>(MockBehavior.Loose);
            stubService.Setup(s => s.GetSummary(It.Is<string>(i => i == "123"))).Returns(new CheckoutSummary()
                {
                    Products = GetProductsStub()
                });

            return stubService.Object;
        }

        private static IEnumerable<Product> GetProductsStub()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product() { ID = 1, ProductName = "Product #1", UnitPrice = 1.99m });
            products.Add(new Product() { ID = 2, ProductName = "Product #2", UnitPrice = 2.99m });
            products.Add(new Product() { ID = 3, ProductName = "Product #3", UnitPrice = 3.99m });

            return products;
        }
    }
}
