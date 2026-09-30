Polimorfismo e conceitos relacionados
Polimorfismo é a capacidade de um objeto ser tratado de forma uniforme mesmo quando o tipo concreto varia, permitindo que a mesma operação seja executada de maneira específica por cada classe.

A palavra-chave virtual marca um método como passível de ser sobrescrito pelas classes derivadas, permitindo o comportamento polimórfico.

A palavra-chave override indica que um método da classe derivada está substituindo um método virtual da classe base.

Quando um método sobrescrito é chamado por meio de uma referência da classe base, a versão executada é a da classe real do objeto em tempo de execução.

Implementar uma interface define um contrato; herdar de uma classe também reutiliza implementação, estado e comportamento da classe base.

Uma classe abstrata não pode ser instanciada porque ela representa um tipo incompleto, com elementos que devem ser definidos pelas classes derivadas.

Um método concreto possui implementação; um método abstrato apenas declara a assinatura e exige implementação nas subclasses.

Virtual permite sobrescrita com implementação existente; abstract exige sobrescrita e não possui implementação na classe base.

Porque Gerente e Programador são subclasses de Funcionario, então ambos podem ser tratados como Funcionario.

A principal vantagem é aumentar a flexibilidade e a extensibilidade do sistema, permitindo tratar diferentes tipos com o mesmo código.
