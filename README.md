# OUNet Management Application

An application for managing OUNet.

## Key Features

*   **User Management:** Manage user accounts, add new users, view account details, and change passwords.
*   **Service Management:** Manage available services and their details.
*   **Billing and Orders:** Manage bills and view order details.
*   **History:** View historical data, such as transaction or login history.
*   **Messaging:** A messaging system for users.
*   **Sensor Management:** Interface for managing and monitoring sensors.
*   **Statistics:** View statistical data related to the application.
*   **Payments:** Integration with the Momo payment service.
*   **Login:** User login with arbitrary username and "admin" password.

## Architecture

The project follows a 3-tier architecture:

*   **DAO (Data Access Objects):** Responsible for data access and persistence.
*   **BUS (Business Logic):** Contains the business logic of the application.
*   **DTO (Data Transfer Objects):** Used to transfer data between layers.

The application is built with C# and the .NET Framework.

## Getting Started

### Prerequisites

*   .NET Framework
*   Visual Studio

### Installation

1.  Clone the repository.
2.  Open the solution file (`OUNet Management Application.sln`) in Visual Studio.
3.  Build the solution to restore the necessary packages.
4.  Run the application.

## Contributing

Contributions are welcome! Please follow these steps:

1.  Pull the latest code from the `master` branch:
    ```sh
    git pull origin master
    ```
2.  Create a new feature branch:
    ```sh
    git branch feature-<your-feature-name>
    ```
3.  Switch to your new branch:
    ```sh
    git checkout feature-<your-feature-name>
    ```
4.  Make your changes and commit them.
5.  Push your changes to your feature branch:
    ```sh
    git push origin feature-<your-feature-name>
    ```
6.  Create a pull request to merge your changes into the `master` branch.
