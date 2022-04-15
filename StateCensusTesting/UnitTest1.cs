using NUnit.Framework;
using State_Census_Problem;
using System;

namespace StateCensusTesting
{
    public class Tests
    {
        CensusAnalyser analyseCensus;
        string filePath = @"E:\c#\Indian-State-Census-Analyser-Problem\State_Census_Problem\";
        string censusDataHeader = "State,Population,AreaInSqKm,DensityPerSqKm";
        string validFileNameCensus = "IndiaStateCensusData.csv";
        string invalidExtensionCensus = "IndiaStateCensusData.txt";
        string invalidHeaderCensus = "HeaderIndiaStateCensusData.csv";
        string invalidDelimeterCensus = "DelimiterIndiaStateCensusData.csv";
        string codeDataHeader = "SrNo,State Name,TIN,StateCode";
        string validFileNameCode = "IndiaStateCode.csv";
        string invalidExtensionCode = "IndiaStateCode.txt";
        string invalidHeaderCode = "HeaderIndiaStateCode.csv";
        string invalidDelimeterCode = "DelimiterIndiaStateCode.csv";

        [SetUp]
        public void Setup()
        {
            analyseCensus = new CensusAnalyser();
        }
        /// <summary>
        /// UC1 : India State Census : TC 1.1, 1.2, 1.3, 1.4, 1.5
        /// </summary>
        [Test]
        public void WhenGivenProper_FilePath_ShouldReturn_Dictionary_StateCensus()
        {
            analyseCensus.dataMap = analyseCensus.LoadCensusData(filePath + validFileNameCensus, 
                censusDataHeader);
            Assert.AreEqual(29, analyseCensus.dataMap.Count);
        }
        [Test]
        public void WhenGivenImproper_FilePath_ShouldThrow_Exception_StateCensus()
        {
            StateCensusException exception = Assert.Throws<StateCensusException>(() =>
            analyseCensus.LoadCensusData(filePath + " " + validFileNameCensus, censusDataHeader));
            Assert.AreEqual(StateCensusException.ExceptionType.FILE_DOES_NOT_EXIST ,exception.type);
        }
        [Test]
        public void WhenGivenImproper_FileExtention_ShouldThrow_Exception_StateCensus()
        {
            StateCensusException exception = Assert.Throws<StateCensusException>(() =>
            analyseCensus.LoadCensusData(filePath + invalidExtensionCensus, censusDataHeader));
            Assert.AreEqual(StateCensusException.ExceptionType.IMPROPER_EXTENTION, exception.type);
        }
        [Test]
        public void WhenGivenImproper_Header_ShouldThrow_Exception_StateCensus()
        {
            StateCensusException exception = Assert.Throws<StateCensusException>(() =>
            analyseCensus.LoadCensusData(filePath + invalidHeaderCensus, censusDataHeader));
            Assert.AreEqual(StateCensusException.ExceptionType.INCORRECT_HEADER, exception.type);
        }
        [Test]
        public void WhenGivenImproper_Delimeter_ShouldThrow_Exception_StateCensus()
        {
            StateCensusException exception = Assert.Throws<StateCensusException>(() =>
            analyseCensus.LoadCensusData(filePath + invalidDelimeterCensus, censusDataHeader));
            Assert.AreEqual(StateCensusException.ExceptionType.INCORRECT_DEMLIMETER, exception.type);
        }
        /// <summary>
        /// UC2 : India State Code : TC 1.1, 1.2, 1.3, 1.4, 1.5
        /// </summary>
        [Test]
        public void WhenGivenProper_FilePath_ShouldReturn_Dictionary_StateCode()
        {
            analyseCensus.dataMap = analyseCensus.LoadCensusData(filePath + validFileNameCode,
                codeDataHeader);
            Assert.AreEqual(37, analyseCensus.dataMap.Count);
        }
        [Test]
        public void WhenGivenImproper_FilePath_ShouldThrow_Exception_StateCode()
        {
            StateCensusException exception = Assert.Throws<StateCensusException>(() =>
            analyseCensus.LoadCensusData(filePath + " " + validFileNameCode, codeDataHeader));
            Assert.AreEqual(StateCensusException.ExceptionType.FILE_DOES_NOT_EXIST, exception.type);
        }
        [Test]
        public void WhenGivenImproper_FileExtention_ShouldThrow_Exception_StateCode()
        {
            StateCensusException exception = Assert.Throws<StateCensusException>(() =>
            analyseCensus.LoadCensusData(filePath + invalidExtensionCode, censusDataHeader));
            Assert.AreEqual(StateCensusException.ExceptionType.IMPROPER_EXTENTION, exception.type);
        }
        [Test]
        public void WhenGivenImproper_Header_ShouldThrow_Exception_StateCode()
        {
            StateCensusException exception = Assert.Throws<StateCensusException>(() =>
            analyseCensus.LoadCensusData(filePath + invalidHeaderCode, codeDataHeader));
            Assert.AreEqual(StateCensusException.ExceptionType.INCORRECT_HEADER, exception.type);
        }
        [Test]
        public void WhenGivenImproper_Delimeter_ShouldThrow_Exception_StateCode()
        {
            StateCensusException exception = Assert.Throws<StateCensusException>(() =>
            analyseCensus.LoadCensusData(filePath + invalidDelimeterCode, codeDataHeader));
            Assert.AreEqual(StateCensusException.ExceptionType.INCORRECT_DEMLIMETER, exception.type);
        }
    }
}