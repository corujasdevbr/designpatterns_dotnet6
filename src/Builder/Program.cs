// See https://aka.ms/new-console-template for more information
using Builder;

Console.WriteLine("Padrão Adapter -  Fluent Interface");
var emailBuilder = new EmailBuilder();
var email = emailBuilder.To("macoratti@yahoo.com")
    .From("teste@email.com")
    .Subject("Assunto do Email")
    .Body("Teste de envio de email")
    .Build();

Console.WriteLine($"{email.From} \n {email.To} \n {email.Subject} \n {email.Body} ");
Console.ReadLine();
