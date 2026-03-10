using System;
using System.Collections.Generic;

namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Ejercicio 1: Diccionario de estudiantes (ID, nombre)
            Console.WriteLine("Ejercicio 1: Diccionario de estudiantes (ID, nombre)");
            Console.WriteLine("Cree un diccionario que almacene ID (int) y nombre (string) de 3 estudiantes. Luego muestre el nombre de uno específico usando su ID.\n");
            Dictionary<int, string> studentDictionary = new Dictionary<int, string>
            {
                { 1, "Juan Pérez" },
                { 2, "María López" },
                { 3, "Carlos Sánchez" }
            };
            int searchId = 2;
            if (studentDictionary.TryGetValue(searchId, out string studentName))
            {
                Console.WriteLine(studentName);
            }
            else
            {
                Console.WriteLine("Estudiante no encontrado");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 2: Diccionario de productos (código, nombre)
            Console.WriteLine("Ejercicio 2: Diccionario de productos (código, nombre)");
            Console.WriteLine("Cree un diccionario donde la clave sea el código de producto (int) y el valor el nombre del producto. Agregue 3 productos e imprímalos.\n");
            Dictionary<int, string> productDictionary = new Dictionary<int, string>();
            productDictionary.Add(101, "Manzanas");
            productDictionary.Add(102, "Naranjas");
            productDictionary.Add(103, "Plátanos");
            foreach (var item in productDictionary)
            {
                Console.WriteLine($"Código: {item.Key}, Producto: {item.Value}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 3: Diccionario de notas (nombre, nota)
            Console.WriteLine("Ejercicio 3: Diccionario de notas (nombre, nota)");
            Console.WriteLine("Cree un diccionario que almacene el nombre (string) y la nota (double) de 3 estudiantes. Luego muestre la nota de uno específico.\n");
            Dictionary<string, double> gradeDictionary = new Dictionary<string, double>();
            gradeDictionary.Add("Juan Pérez", 85.5);
            gradeDictionary.Add("María López", 92.0);
            gradeDictionary.Add("Carlos Sánchez", 78.3);
            string searchStudent = "María López";
            if (gradeDictionary.TryGetValue(searchStudent, out double grade))
            {
                Console.WriteLine($"Nota de {searchStudent}: {grade}");
            }
            else
            {
                Console.WriteLine("Estudiante no encontrado");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 4: Diccionario de ciudades (código, nombre)
            Console.WriteLine("Ejercicio 4: Diccionario de ciudades (código, nombre)");
            Console.WriteLine("Cree un diccionario que almacene el código (int) y el nombre (string) de 5 ciudades. Luego muestre el nombre de una ciudad usando su código.\n");
            Dictionary<int, string> cityDictionary = new Dictionary<int, string>();
            cityDictionary.Add(1, "Flores");
            cityDictionary.Add(2, "Quetzaltenango");
            cityDictionary.Add(3, "Ciudad de Guatemala");
            cityDictionary.Add(4, "Huehuetenango");
            cityDictionary.Add(5, "Chimaltenango");
            int searchCityCode = 3;
            if (cityDictionary.TryGetValue(searchCityCode, out string cityName))
            {
                Console.WriteLine(cityName);
            }
            else
            {
                Console.WriteLine("Ciudad no encontrada");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 5: Diccionario de usuario y contraseña
            Console.WriteLine("Ejercicio 5: Diccionario de usuario y contraseña");
            Console.WriteLine("Cree un diccionario que almacene un nombre de usuario (string) y una contraseña (string). Agregue 3 usuarios y muestre la contraseña de uno de ellos.\n");
            Dictionary<string, string> userPasswordDictionary = new Dictionary<string, string>();
            userPasswordDictionary.Add("usuario1", "contraseña123");
            userPasswordDictionary.Add("usuario2", "clave456");
            userPasswordDictionary.Add("usuario3", "pass789");
            string searchUser = "usuario2";
            if (userPasswordDictionary.TryGetValue(searchUser, out string password))
            {
                Console.WriteLine($"Contraseña de {searchUser}: {password}");
            }
            else
            {
                Console.WriteLine("Usuario no encontrado");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 6: Diccionario de estudiantes, eliminar uno
            Console.WriteLine("Ejercicio 6: Diccionario de estudiantes, eliminar uno");
            Console.WriteLine("Cree un diccionario y agregue 3 estudiantes. Luego elimine uno de ellos y muestre la lista actualizada.\n");
            Dictionary<int, string> studentRemoveDictionary = new Dictionary<int, string>();
            studentRemoveDictionary.Add(1, "Juan Pérez");
            studentRemoveDictionary.Add(2, "María López");
            studentRemoveDictionary.Add(3, "Carlos Sánchez");
            studentRemoveDictionary.Remove(2);
            foreach (var item in studentRemoveDictionary)
            {
                Console.WriteLine($"ID: {item.Key}, Nombre: {item.Value}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 7: Diccionario de productos, verificar clave antes de agregar
            Console.WriteLine("Ejercicio 7: Diccionario de productos, verificar clave antes de agregar");
            Console.WriteLine("Cree un diccionario y agregue un producto. Luego intente agregar otro producto con la misma clave y muestre un mensaje adecuado.\n");
            Dictionary<int, string> productCheckDictionary = new Dictionary<int, string>();
            productCheckDictionary.Add(1, "Leche");
            int newProductCode = 1;
            if (!productCheckDictionary.ContainsKey(newProductCode))
            {
                productCheckDictionary.Add(newProductCode, "Pan");
            }
            else
            {
                Console.WriteLine("El código ya existe");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 8: Diccionario de empleados, modificar nombre
            Console.WriteLine("Ejercicio 8: Diccionario de empleados, modificar nombre");
            Console.WriteLine("Cree un diccionario y agregue 2 empleados. Luego modifique el nombre de uno de ellos y muestre la lista actualizada.\n");
            Dictionary<int, string> employeeDictionary = new Dictionary<int, string>();
            employeeDictionary.Add(1, "Ana Torres");
            employeeDictionary.Add(2, "Luis Gómez");
            employeeDictionary[2] = "Luis Fernández";
            foreach (var item in employeeDictionary)
            {
                Console.WriteLine($"ID: {item.Key}, Nombre: {item.Value}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 9: Diccionario de notas, verificar existencia antes de mostrar
            Console.WriteLine("Ejercicio 9: Diccionario de notas, verificar existencia antes de mostrar");
            Console.WriteLine("Cree un diccionario y agregue 2 estudiantes. Luego pida el nombre de un estudiante y muestre su nota si existe, o un mensaje de no encontrado.\n");
            Dictionary<string, double> gradeCheckDictionary = new Dictionary<string, double>();
            gradeCheckDictionary.Add("Juan Pérez", 85.5);
            gradeCheckDictionary.Add("María López", 92.0);
            Console.Write("Ingrese el nombre del estudiante: ");
            string inputName = Console.ReadLine();
            if (gradeCheckDictionary.TryGetValue(inputName, out double inputGrade))
            {
                Console.WriteLine($"Nota: {inputGrade}");
            }
            else
            {
                Console.WriteLine("Estudiante no encontrado");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 10: Diccionario de inventario, eliminar producto por código
            Console.WriteLine("Ejercicio 10: Diccionario de inventario, eliminar producto por código");
            Console.WriteLine("Cree un diccionario y agregue 3 productos. Luego pida el código de un producto a eliminar y muestre un mensaje indicando si fue eliminado o no encontrado.\n");
            Dictionary<int, string> inventoryDictionary = new Dictionary<int, string>();
            inventoryDictionary.Add(1, "Teclado");
            inventoryDictionary.Add(2, "Ratón");
            inventoryDictionary.Add(3, "Monitor");
            Console.Write("Ingrese el código del producto a eliminar: ");
            int codeToRemove;
            if (int.TryParse(Console.ReadLine(), out codeToRemove))
            {
                if (inventoryDictionary.Remove(codeToRemove))
                {
                    Console.WriteLine("Producto eliminado");
                }
                else
                {
                    Console.WriteLine("Código no encontrado");
                }
            }
            else
            {
                Console.WriteLine("Código inválido");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 11: Diccionario de estudiantes, recorrer con foreach
            Console.WriteLine("Ejercicio 11: Diccionario de estudiantes, recorrer con foreach");
            Console.WriteLine("Cree un diccionario y agregue 5 estudiantes. Luego recorra el diccionario con un foreach y muestre cada ID y nombre.\n");
            Dictionary<int, string> studentForeachDictionary = new Dictionary<int, string>();
            studentForeachDictionary.Add(1, "Juan Pérez");
            studentForeachDictionary.Add(2, "María López");
            studentForeachDictionary.Add(3, "Carlos Sánchez");
            studentForeachDictionary.Add(4, "Ana Torres");
            studentForeachDictionary.Add(5, "Luis Gómez");
            foreach (var item in studentForeachDictionary)
            {
                Console.WriteLine($"ID: {item.Key}, Nombre: {item.Value}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 12: Diccionario de productos, mostrar todos los códigos y nombres
            Console.WriteLine("Ejercicio 12: Diccionario de productos, mostrar todos los códigos y nombres");
            Console.WriteLine("Cree un diccionario y agregue 3 productos. Luego recorra el diccionario y muestre todos los códigos y nombres de productos.\n");
            Dictionary<int, string> productShowDictionary = new Dictionary<int, string>();
            productShowDictionary.Add(1, "Leche");
            productShowDictionary.Add(2, "Pan");
            productShowDictionary.Add(3, "Huevos");
            foreach (var item in productShowDictionary)
            {
                Console.WriteLine($"Código: {item.Key}, Producto: {item.Value}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 13: Diccionario de notas, calcular promedio
            Console.WriteLine("Ejercicio 13: Diccionario de notas, calcular promedio");
            Console.WriteLine("Cree un diccionario y agregue 3 estudiantes con sus notas. Luego calcule y muestre el promedio de las notas.\n");
            Dictionary<string, double> gradeAverageDictionary = new Dictionary<string, double>();
            gradeAverageDictionary.Add("Juan Pérez", 85.5);
            gradeAverageDictionary.Add("María López", 92.0);
            gradeAverageDictionary.Add("Carlos Sánchez", 78.3);
            double sum = 0;
            foreach (var item in gradeAverageDictionary)
            {
                sum += item.Value;
            }
            double average = sum / gradeAverageDictionary.Count;
            Console.WriteLine($"Promedio general: {average}");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 14: Diccionario de ciudades, mostrar claves y valores
            Console.WriteLine("Ejercicio 14: Diccionario de ciudades, mostrar claves y valores");
            Console.WriteLine("Cree un diccionario y agregue 5 ciudades. Luego muestre todas las claves y valores por separado.\n");
            Dictionary<int, string> cityShowDictionary = new Dictionary<int, string>();
            cityShowDictionary.Add(1, "Madrid");
            cityShowDictionary.Add(2, "Barcelona");
            cityShowDictionary.Add(3, "Valencia");
            cityShowDictionary.Add(4, "Sevilla");
            cityShowDictionary.Add(5, "Bilbao");
            Console.Write("Claves: ");
            foreach (var key in cityShowDictionary.Keys)
            {
                Console.Write($"{key} ");
            }
            Console.WriteLine();
            Console.Write("Valores: ");
            foreach (var value in cityShowDictionary.Values)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 15: Diccionario de empleados, mostrar formato
            Console.WriteLine("Ejercicio 15: Diccionario de empleados, mostrar formato");
            Console.WriteLine("Cree un diccionario y agregue 2 empleados. Luego muéstrelo en un formato específico: 'ID: {id} Nombre: {nombre}'.\n");
            Dictionary<int, string> employeeShowDictionary = new Dictionary<int, string>();
            employeeShowDictionary.Add(1, "Ana Torres");
            employeeShowDictionary.Add(2, "Luis Gómez");
            foreach (var item in employeeShowDictionary)
            {
                Console.WriteLine($"ID: {item.Key} Nombre: {item.Value}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 16: Menú para agregar y mostrar estudiantes
            Console.WriteLine("Ejercicio 16: Menú para agregar y mostrar estudiantes");
            Console.WriteLine("Cree un menú que permita agregar estudiantes (ID y nombre) a un diccionario, y mostrar todos los estudiantes. Use un bucle para mantener el menú activo.\n");
            Dictionary<int, string> studentMenuDictionary = new Dictionary<int, string>();
            bool exitStudentMenu = false;
            while (!exitStudentMenu)
            {
                Console.WriteLine("1. Agregar estudiante");
                Console.WriteLine("2. Mostrar estudiantes");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Write("Ingrese el ID: ");
                    int id;
                    if (int.TryParse(Console.ReadLine(), out id))
                    {
                        Console.Write("Ingrese el nombre: ");
                        string name = Console.ReadLine();
                        studentMenuDictionary[id] = name;
                    }
                }
                else if (option == 2)
                {
                    foreach (var item in studentMenuDictionary)
                    {
                        Console.WriteLine($"ID: {item.Key}, Nombre: {item.Value}");
                    }
                }
                else if (option == 3)
                {
                    exitStudentMenu = true;
                }
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 17: Menú de inventario
            Console.WriteLine("Ejercicio 17: Menú de inventario");
            Console.WriteLine("Cree un menú que permita agregar productos (código y nombre) a un diccionario, eliminar productos por código, y mostrar todos los productos. Use un bucle para mantener el menú activo.\n");
            Dictionary<int, string> inventoryMenuDictionary = new Dictionary<int, string>();
            bool exitInventoryMenu = false;
            while (!exitInventoryMenu)
            {
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("3. Mostrar productos");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Write("Ingrese el código: ");
                    int code;
                    if (int.TryParse(Console.ReadLine(), out code))
                    {
                        Console.Write("Ingrese el nombre: ");
                        string name = Console.ReadLine();
                        inventoryMenuDictionary[code] = name;
                    }
                }
                else if (option == 2)
                {
                    Console.Write("Ingrese el código a eliminar: ");
                    int code;
                    if (int.TryParse(Console.ReadLine(), out code))
                    {
                        inventoryMenuDictionary.Remove(code);
                    }
                }
                else if (option == 3)
                {
                    foreach (var item in inventoryMenuDictionary)
                    {
                        Console.WriteLine($"Código: {item.Key}, Producto: {item.Value}");
                    }
                }
                else if (option == 4)
                {
                    exitInventoryMenu = true;
                }
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 18: Registrar usuarios y validar existencia
            Console.WriteLine("Ejercicio 18: Registrar usuarios y validar existencia");
            Console.WriteLine("Cree un diccionario para registrar usuarios (nombre de usuario y contraseña). Verifique si el usuario ya existe antes de registrarlo.\n");
            Dictionary<string, string> userRegisterDictionary = new Dictionary<string, string>();
            Console.Write("Ingrese el usuario a registrar: ");
            string newUser = Console.ReadLine();
            if (!userRegisterDictionary.ContainsKey(newUser))
            {
                Console.Write("Ingrese la contraseña: ");
                string newPassword = Console.ReadLine();
                userRegisterDictionary[newUser] = newPassword;
                Console.WriteLine("Usuario registrado");
            }
            else
            {
                Console.WriteLine("El usuario ya existe");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 19: Sistema de notas, ingresar, modificar y mostrar
            Console.WriteLine("Ejercicio 19: Sistema de notas, ingresar, modificar y mostrar");
            Console.WriteLine("Cree un sistema que permita ingresar estudiantes y sus notas, modificar notas existentes, y mostrar todas las notas. Use un bucle para mantener el sistema activo.\n");
            Dictionary<string, double> gradeSystemDictionary = new Dictionary<string, double>();
            bool exitGradeSystem = false;
            while (!exitGradeSystem)
            {
                Console.WriteLine("1. Ingresar estudiante");
                Console.WriteLine("2. Modificar nota");
                Console.WriteLine("3. Mostrar notas");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Write("Ingrese el nombre: ");
                    string name = Console.ReadLine();
                    Console.Write("Ingrese la nota: ");
                    double note;
                    if (double.TryParse(Console.ReadLine(), out note))
                    {
                        gradeSystemDictionary[name] = note;
                    }
                }
                else if (option == 2)
                {
                    Console.Write("Ingrese el nombre: ");
                    string name = Console.ReadLine();
                    if (gradeSystemDictionary.ContainsKey(name))
                    {
                        Console.Write("Ingrese la nueva nota: ");
                        double note;
                        if (double.TryParse(Console.ReadLine(), out note))
                        {
                            gradeSystemDictionary[name] = note;
                        }
                    }
                }
                else if (option == 3)
                {
                    foreach (var item in gradeSystemDictionary)
                    {
                        Console.WriteLine($"Nombre: {item.Key}, Nota: {item.Value}");
                    }
                }
                else if (option == 4)
                {
                    exitGradeSystem = true;
                }
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 20: Diccionario con carné y tupla (Nombre, Edad, Carrera)
            Console.WriteLine("Ejercicio 20: Diccionario con carné y tupla (Nombre, Edad, Carrera)");
            Console.WriteLine("Cree un diccionario donde la clave sea un número de carné (int) y el valor una tupla con el nombre (string), edad (int) y carrera (string). Agregue 3 registros e imprímalos.\n");
            Dictionary<int, (string, int, string)> carnetDictionary = new Dictionary<int, (string, int, string)>();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese el carné: ");
                int carnet;
                if (int.TryParse(Console.ReadLine(), out carnet))
                {
                    Console.Write("Ingrese el nombre: ");
                    string name = Console.ReadLine();
                    Console.Write("Ingrese la edad: ");
                    int age;
                    if (int.TryParse(Console.ReadLine(), out age))
                    {
                        Console.Write("Ingrese la carrera: ");
                        string career = Console.ReadLine();
                        carnetDictionary[carnet] = (name, age, career);
                    }
                }
            }
            foreach (var item in carnetDictionary)
            {
                Console.WriteLine($"Carné: {item.Key}, Nombre: {item.Value.Item1}, Edad: {item.Value.Item2}, Carrera: {item.Value.Item3}");
            }
        }
    }
}