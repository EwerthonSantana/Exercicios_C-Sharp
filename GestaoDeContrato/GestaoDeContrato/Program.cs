using GestaoDeContrato.Services;
using GestaoDeContrato.Entities;
using System.Globalization;

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int numberOfContract = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime dateStartContract = DateTime.Parse(Console.ReadLine());
Console.Write("Contract value: ");
double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter number of installments: ");
int quantityInstallments = int.Parse(Console.ReadLine());

Contract contract = new Contract(numberOfContract, dateStartContract, contractValue);

ContractService contractService = new(new PaypalService());

contractService.ProcessContract(contract, quantityInstallments);

Console.WriteLine("Instalmments: ");
foreach (Installment installment in contract.Installments) {
    Console.WriteLine(installment);
}
