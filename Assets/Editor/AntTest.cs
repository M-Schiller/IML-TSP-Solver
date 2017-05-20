﻿
/****************************************************
 * IML ACO implementation for TSP 
 * More information: http://hci-kdd.org/project/iml/
 * Author: Andrej Mueller
 * Year: 2017
 *****************************************************/

/* AntAlgorithSimpleTest */

using System.Collections.Generic;
using NUnit.Framework;
using System.Reflection;
[assembly: AssemblyVersion("0.1")]

[TestFixture]
public class AntTest
{
    private List<City> cities;
    private AntAlgorithms.AntAlgorithmChooser antAlgorithmChooser;
    private AntAlgorithms.AntAlgorithm antAlgorithm;


    [OneTimeSetUp]
    public void Init()
    {
        //Init runs once before running test cases.
    }

    [OneTimeTearDown]
    public void CleanUp()
    {
        //CleanUp runs once after all test cases are finished.
    }

    [SetUp]
    public void SetUp()
    {
        cities = new List<City>();

    }

    [TearDown]
    public void TearDown()
    {
        //SetUp runs after all test cases
    }

    [Test]
    public void Eil51ACS()
    {
        antAlgorithmChooser = new AntAlgorithms.AntAlgorithmChooser(1, 2, 0.1, 20, 0.9);
        antAlgorithm = antAlgorithmChooser.Algorithm;
        antAlgorithm.Cities = TSPImporter.ImportTsp("eil51.tsp");
        antAlgorithm.Init();
        for (int i = 0; i < 1000; i++)
        {
            antAlgorithm.Iteration();
        }
        antAlgorithm.PrintBestTour("Eil51ACS");
        Assert.True(true);
    }

    [Test]
    public void Eil51AS()
    {
        antAlgorithmChooser = new AntAlgorithms.AntAlgorithmChooser(1, 2, 0.7, 100);
        antAlgorithm = antAlgorithmChooser.Algorithm;
        antAlgorithm.Cities = TSPImporter.ImportTsp("eil51.tsp");
        antAlgorithm.Init();
        for (int i = 0; i < 3000; i++)
        {
            antAlgorithm.Iteration();
        }
        antAlgorithm.PrintBestTour("Eil51AS");
        Assert.True(true);
    }

    [Test]
    public void Oliver30ACS()
    {
        antAlgorithmChooser = new AntAlgorithms.AntAlgorithmChooser(1, 2, 0.1, 10, 0.9);
        antAlgorithm = antAlgorithmChooser.Algorithm;
        antAlgorithm.Cities = TSPImporter.ImportTsp("oliver30.tsp");
        antAlgorithm.Init();
        for (int i = 0; i < 5000; i++)
        {
            antAlgorithm.Iteration();
        }
        antAlgorithm.PrintBestTour("Oliver30ACS");
        Assert.True(true);
    }

    [Test]
    public void Oliver30AS()
    {
        antAlgorithmChooser = new AntAlgorithms.AntAlgorithmChooser(1, 2, 0.7, 10);
        antAlgorithm = antAlgorithmChooser.Algorithm;
        antAlgorithm.Cities = TSPImporter.ImportTsp("oliver30.tsp");
        antAlgorithm.Init();
        for (int i = 0; i < 2500; i++)
        {
            antAlgorithm.Iteration();
        }
        antAlgorithm.PrintBestTour("Oliver30AS");
        Assert.True(true);
    }

    [Test]
    public void Oliver30ACSWithCustomPara()
    {
        antAlgorithmChooser = new AntAlgorithms.AntAlgorithmChooser(AntAlgorithms.Mode.AntColonySystem, 1, 2, 0.1, 10, 0.9, 0.000088, 0.000088);
        antAlgorithm = antAlgorithmChooser.Algorithm;
        antAlgorithm.Cities = TSPImporter.ImportTsp("oliver30.tsp");
        antAlgorithm.Init();
        for (int i = 0; i < 1000; i++)
        {
            antAlgorithm.Iteration();
        }
        antAlgorithm.PrintBestTour("Oliver30ACSWithCustomPara");
        Assert.True(true);
    }

    [Test]
    public void Berlin52ACS()
    {
        antAlgorithmChooser = new AntAlgorithms.AntAlgorithmChooser(1, 2, 0.1, 10, 0.9);
        antAlgorithm = antAlgorithmChooser.Algorithm;
        antAlgorithm.Cities = TSPImporter.ImportTsp("berlin52.tsp");
        antAlgorithm.Init();
        for (int i = 0; i < 200; i++)
        {
            antAlgorithm.Iteration();
        }
        antAlgorithm.PrintBestTour("berlin52");
        Assert.True(true);
    }

    [Test]
    public void test8()
    {
        antAlgorithmChooser = new AntAlgorithms.AntAlgorithmChooser(1, 2, 0.1, 10, 0.9);
        antAlgorithm = antAlgorithmChooser.Algorithm;

        cities.Add(new City(2, 4, 0));
        cities.Add(new City(1, 9, 1));
        cities.Add(new City(3, 8, 2));
        cities.Add(new City(9, 1, 3));
        cities.Add(new City(10, 1, 4));

        cities.Add(new City(5, 4, 5));
        cities.Add(new City(1, 11, 6));
        cities.Add(new City(3, 4, 7));

        antAlgorithm.Cities = cities;
        antAlgorithm.Init();
        for (int i = 0; i < 400; i++)
            antAlgorithm.Iteration();
        antAlgorithm.PrintBestTour("test8");
        Assert.True(true);
    }

}