# NSLP (National Student Lunch Program)

NSLP is a web application built with Blazor WebAssembly for the front-end and Web API for the back-end. It serves as a tool to support the National School Lunch Program (NSLP), providing data analysis, visualization, and reporting capabilities for administrators and stakeholders involved in managing and monitoring the NSLP.

## Overview

The National School Lunch Program (NSLP) is a federally assisted meal program operating in public and nonprofit private schools and residential child care institutions. It provides nutritionally balanced, low-cost, or free lunches to eligible children each school day.

This project aims to provide a web-based platform for administrators and stakeholders involved in the NSLP to:

- Analyze participation rates and trends
- Visualize nutritional data and meal patterns
- Generate reports for compliance and program evaluation

## Features

- Utilizes Blazor WebAssembly for interactive and responsive front-end user interface.
- Implements Web API for handling data processing, analysis, and report generation on the server-side.
- Supports various data input formats for flexibility in data management.
- Provides customizable reporting options for tailored insights.

## Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/irisjohansene/NSLP.git
    ```

2. Navigate to the `NSLP.NSLPWasm` directory for the front-end Blazor WebAssembly application and `NSLP.NSLPWebApi` directory for the back-end Web API.

3. Install dependencies for each project:

    ```bash
    dotnet restore
    ```

## Usage

1. Run the back-end Web API:

    ```bash
    cd NSLP.NSLPWebApi
    dotnet run
    ```

2. Launch the front-end Blazor WebAssembly application:

    ```bash
    cd NSLP.NSLPWasm
    dotnet run
    ```

3. Access the application in your web browser and start exploring the features.

## Credits

- Implementation by [irisjohansene](https://github.com/irisjohansene)
- Inspired by the National School Lunch Program (NSLP)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
