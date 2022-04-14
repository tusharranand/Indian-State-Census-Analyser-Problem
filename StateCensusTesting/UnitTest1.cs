using NUnit.Framework;
using State_Census_Problem;
using System;

namespace StateCensusTesting
{
    public class Tests
    {
        CensusAnalyser analyseCensus;
        string filePath = @"E:\c#\Indian-State-Census-Analyser-Problem\State_Census_Problem\";
        string validFileName = "IndiaStateCensusData.csv";
        string invalidExtension = "IndiaStateCensusData.txt";
        string invalidHeader = "HeaderIndiaStateCensusData.csv";
        string invalidDelimeter = "DelimiterIndiaStateCensusData.csv";
        [SetUp]
        public void Setup()
        {
            analyseCensus = new CensusAnalyser();
        }

        [Test]
        public void WhenGivenProper_FilePath_ShouldReturn_Dictionary()
        {
            analyseCensus.dataMap = analyseCensus.LoadCensusData(filePath + validFileName);
            Assert.AreEqual(29, analyseCensus.dataMap.Count);
        }
        [Test]
        public void WhenGivenImproper_FilePath_ShouldThrow_Exception()
        {
            StateCensusException exception = Assert.Throws<StateCensusException>(() =>
            analyseCensus.LoadCensusData(filePath + " " + validFileName));
            Assert.AreEqual(StateCensusException.ExceptionType.FILE_DOES_NOT_EXIST ,exception.type);
        }
        [Test]
        public void WhenGivenImproper_FileExtention_ShouldThrow_Exception()
        {
            StateCensusException exception = Assert.Throws<StateCensusException>(() =>
            analyseCensus.LoadCensusData(filePath + invalidExtension));
            Assert.AreEqual(StateCensusException.ExceptionType.IMPROPER_EXTENTION, exception.type);
        }
        [Test]
        public void WhenGivenImproper_Header_ShouldThrow_Exception()
        {
            StateCensusException exception = Assert.Throws<StateCensusException>(() =>
            analyseCensus.LoadCensusData(filePath + invalidHeader));
            Assert.AreEqual(StateCensusException.ExceptionType.INCORRECT_HEADER, exception.type);
        }
        [Test]
        public void WhenGivenImproper_Delimeter_ShouldThrow_Exception()
        {
            StateCensusException exception = Assert.Throws<StateCensusException>(() =>
            analyseCensus.LoadCensusData(filePath + invalidDelimeter));
            Assert.AreEqual(StateCensusException.ExceptionType.INCORRECT_DEMLIMETER, exception.type);
        }
    }
}