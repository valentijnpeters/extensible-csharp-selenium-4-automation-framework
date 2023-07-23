# Extensible Java Selenium 4 Automation Framework

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

* Simply rebuilding the solution should be sufficient.
* Before running a test you will need to manually point to the configuration file (`local.runsettings`)
    * Open Test Explorer
    * Click Options --> Configure Run Settings
    * Select Solution Wide runsettings File
    * Point to the configuration file that should be in: `\Base\Configuration`


### Executing tests

* Open Test Explorer
* Right-click a test and select `Run` or `Debug`

### Project Structure Overview

* Base
  * Provides the generic base of the framework
* System Under Test ([SUT](https://en.wikipedia.org/wiki/System_under_test))
    * Pages (Page Objects)
    * Tests

### Authors

* Bernard Visagie

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