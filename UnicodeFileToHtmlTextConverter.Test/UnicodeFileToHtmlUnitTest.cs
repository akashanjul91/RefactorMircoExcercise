using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnicodeFileToHtmlTextConverter.Test
{
    [TestClass]
    public class UnicodeFileToHtmlUnitTest
    {
        [TestMethod]
        public void TestConvertToHtml()
        {
            var filename = "aFilename.txt";
            var textConverter = new TDDMicroExercises.UnicodeFileToHtmlTextConverter.UnicodeFileToHtmlTextConverter();
            var html = textConverter.ConvertToHtml(filename);
            Assert.IsTrue(!String.IsNullOrEmpty(html));
        }

        [TestMethod]
        public void TestConvertToHtml_Negative()
        {
            var filename = "";
            var textConverter = new TDDMicroExercises.UnicodeFileToHtmlTextConverter.UnicodeFileToHtmlTextConverter();
            var html = textConverter.ConvertToHtml(filename);
            Assert.IsTrue(String.IsNullOrEmpty(html));
        }

        [TestMethod]
        public void TestFileExists_Positive()
        {
            var filename = "aFilename.txt";
            var textConverter = new TDDMicroExercises.UnicodeFileToHtmlTextConverter.UnicodeFileToHtmlTextConverter();
            bool isPathExist = textConverter.CheckFileExistence(filename);
            Assert.IsTrue(isPathExist);
        }

        [TestMethod]
        public void TestFileExists_Negative()
        {
            var filename = "bFilename.txt";
            var textConverter = new TDDMicroExercises.UnicodeFileToHtmlTextConverter.UnicodeFileToHtmlTextConverter();
            bool isPathExist = textConverter.CheckFileExistence(filename);
            Assert.IsFalse(isPathExist);
        }

        [TestMethod]
        public void TestCheckFileExtensionisTXT_Positive()
        {
            var filename = "aFilename.TXT";
            var textConverter = new TDDMicroExercises.UnicodeFileToHtmlTextConverter.UnicodeFileToHtmlTextConverter();
            bool isPathExist = textConverter.CheckFileExtensionisTXT(filename);
            Assert.IsTrue(isPathExist);
        }
        [TestMethod]
        public void TestCheckFileExtensionisTXT_Negative()
        {
            var filename = "aFilename.CSV";
            var textConverter = new TDDMicroExercises.UnicodeFileToHtmlTextConverter.UnicodeFileToHtmlTextConverter();
            bool isPathExist = textConverter.CheckFileExtensionisTXT(filename);
            Assert.IsFalse(isPathExist);
        }

    }
}
