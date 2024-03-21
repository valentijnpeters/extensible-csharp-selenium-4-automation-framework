# Extensible C Sharp Selenium 4 Automation Framework

The purpose of this Framework is to serve as a functional demo and / or template to be used on projects and / or assist
with training. This framework attempts to showcase a type of simple boilerplate Selenium 4 framework.
Using [Wikipedia](https://www.wikipedia.org/) as our system under test.

## Description

The project consists of the following primary elements and technologies:

* [Selenium 4](https://www.selenium.dev/) Selenium is a suite of tools for automating web browsers. The latest major
  version at this time is 4.
* [NUnit](https://nunit.org/) NUnit is a unit-testing framework for all .Net languages.

## Installation and Usage

### Required software

* .Net 7 project

### Installing

* Simply rebuilding the solution should be sufficient.![extra1](https://github.com/valentijnpeters/extensible-csharp-selenium-4-automation-framework/assets/49692812/17d3f80f-1fba-41ef-8c95-4b861262fbfa)

* Before running a test you will need to manually point to the configuration file (`local.runsettings`)
    * Open Test Explorer
    * Click Options --> Configure Run Settings
    * Select Solution Wide runsettings File
    * Point to the configuration file that should be in: `\Base\Configuration`![extra3](https://github.com/valentijnpeters/extensible-csharp-selenium-4-automation-framework/assets/49692812/b1963feb-f352-4500-a05a-f92c55419589)

it searches for Chromedriver 83, we are at 123 at the moment. 
![extra4](https://github.com/valentijnpeters/extensible-csharp-selenium-4-automation-framework/assets/49692812/2ffa7934-3974-4e1b-9eff-0f019d2603ba)

What I did was go to the ProjectExplorer, right click on everything and then Update (I updated everything)![extra5](https://github.com/valentijnpeters/extensible-csharp-selenium-4-automation-framework/assets/49692812/f71e88b3-5662-4f5c-a5fc-f85e26f4fc67)

It still didn't work, but after changing in the file 'local.runsettings' to this: Parameter name="TargetBrowser" value="Edge"  everythying starting working smoothly. Edge to the rescue!

### Executing tests

* Open Test Explorer![extra2](https://github.com/valentijnpeters/extensible-csharp-selenium-4-automation-framework/assets/49692812/6b229095-039d-4819-beb1-022e644cbd4f)

* Right-click a test and select `Run` or `Debug`

### Project Structure Overview

* Base
  * Provides the generic base of the framework
* System Under Test ([SUT](https://en.wikipedia.org/wiki/System_under_test))
    * Pages (Page Objects)
    * Tests

### Authors

* Bernard Visagie, Valentijn Peters(for this Fork version README.md)

### License

MIT License

Copyright (c) 2023 - Bernard Visagie

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
