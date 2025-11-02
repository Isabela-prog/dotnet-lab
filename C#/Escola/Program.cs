
//saber onde aluno está
using Net.C_.Escola;
using NET.C_.Escola;

//métodos construtores -> inicializar objetos
//new -> palavra reservada usada para criar uma nova instância de uma classe 
var aluno1 = new Aluno();
aluno1.Nome = "João Silva";
aluno1.Matricula = 12345;
aluno1.Email = "joaosilva@email.com";
aluno1.Senha = "senhaSegura123";

//aluno1.CalcularMedia(8.5m, 7.0m, 9.0m);
//aluno pegará o método logar da classe Aluno
aluno1.Logar();


//polimorfismo -> quando estanciar pela classe base, nesse caso aluno só terá comportamentos de usuário
Usuario alunoUsuario2 = new Aluno();

//alunousuario pegará o método logar de usuário
alunoUsuario2.Logar();