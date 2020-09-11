
Análise e Desenvolvimento de Sistemas - Senac 2020

# Documentação

PROJETO EMBUTIDOS FILIPINI

  

**Disciplina:**

Arquitetura e Sistemas e Gestão da Informação

  

**Professora:**

Claudia Werlich

  

**Equipe:**

- Alisson Wenceslau.

- Carlos Eduardo Floresta (Líder do Projeto).

- Leonardo Balitski Filipini.

- Lucas Elmer Martins.

- Matheus Henrique Rech.

  

**EMBUTIDOS FILIPINI**

  

A Empresa: Trata-se da criação de um sistema para uma pequena empresa de embutidos caseiros no interior do Paraná que além de produzir, fornece os produtos para pequenos comércios e atende os clientes finais.

![enter image description here](<img  src="https://www.ead.senac.br/arquivo/api/download/publico/1134"  alt="drawing"  width="400"/><br>

Análise e Desenvolvimento de Sistemas - Senac 2020

## Documentação
PROJETO EMBUTIDOS FILIPINI 

**Disciplina:** Arquitetura e Sistemas e Gestão da Informação.

**Professora:** Claudia Werlich.  

**Equipe:**
- Alisson Wenceslau.
- Carlos Eduardo Floresta (Líder do Projeto).
- Leonardo Balitski Filipini.
- Lucas Elmer Martins.
- Matheus Henrique Rech.
---
  

## EMBUTIDOS FILIPINI
A Empresa: Trata-se da criação de um sistema para uma pequena empresa de embutidos caseiros no interior do Paraná que além de produzir, fornece os produtos para pequenos comércios e atende os clientes finais.  

O Sistema: A empresa Embutidos Filipini necessita de um sistema que seja utilizado em desktop e smartphones. Ele tem como função principal gerenciar todo o processo de compra de produtos e matérias-primas produção e venda dos produtos fabricados. 

São eles: 

**CADASTRO**  
Esse mesmo sistema terá o cadastro dos usuários: o usuário proprietário, o usuário funcionário e o usuário fornecedor, cada um com o acesso a parte do sistema de interesse. Há também o cadastro de clientes físicos e jurídicos e de todo o produto e matérias primas utilizadas. 

Cada cadastro deverá ser completo com todos os dados necessários para obter o máximo de informações, tais como: Nome, razão social, CPF, CNPJ, nome do representante (fornecedor) endereço, telefones para contato, e-mail, data do cadastro. 

Como trata-se de uma empresa que trabalha com materiais perecíveis, o cadastro deverá ter o nome do produto, descrição, marca e a validade.  

**Acessos:**

Tipo Usuário | Tipo Acesso
--- | ------
Usuário: proprietário | Acesso total.
Usuário: funcionário | Acesso ao cadastro de clientes, produtos, materiais e a tela de vendas.
Usuário: fornecedor | Acesso a tela de orçamentos e pedidos.  

**RELATÓRIOS**
O sistema também comportará uma tela de Relatórios para controle de despesas/lucro, dentre ele estarão relatórios de Compras e Vendas (diário, semanal, mensal e anual). Há também a relação de todos os produtos e materiais comprados e vendidos e relação total de clientes e devedores e a relação de fornecedores. 

**VENDAS**
A tela de vendas será simples, dentro da legislação do comercio e impostos: O usuário entrará com o cadastro de clientes quando a compra for para pagamento posterior, incluirá os produtos, informará o total ao cliente e optar pela forma de pagamento, sendo eles: dinheiro, cartão de crédito ou débito e pagamento posterior.

 **COMPRAS**
A tela de compras será muito parecida com a tela de vendas, ou seja, o usuário proprietário entrará com o cadastro do fornecedor, incluirá os produtos para compra e enviará o pedido via sistema para orçamento. O usuário fornecedor fará o orçamento do pedido e retornará o mesmo com os preços de cada produto, total, data de entrega e faturamento. Feito a confirmação do pedido pelo usuário proprietário, o usuário fornecedor receber á a notificação de confirmação de pedido.

  ___

## MENU DE DECOMPOSIÇÃO FUNCIONAL
![enter image description here](ze) 

## REQUISITOS
- Parte 1
![enter image description here](ze) 
- Parte 2
![enter image description here](ze)
- Parte 3
![enter image description here](ze)
  
## CASO DE USO GERAL**
![enter image description here](ze)

**CASO DE USO - COMPRAS**
![enter image description here](ze)

**CASO DE USO – VENDAS**
![enter image description here](ze)

 **CASO DE USO - RELATÓRIOS**
![enter image description here](ze)  

**CASO DE USO - CADASTRO**
![enter image description here](ze)  

## DIAGRAMA DE CLASSES
![enter image description here](ze)  

## DIAGRAMA ENTIDADE - RELACIONAMENTO
![enter image description here](ze)  

## SISTEMA ERP  

**ENTENDENDO**
Planejamento de Recursos Empresariais (em inglês é um [sistema de informação](https://pt.wikipedia.org/wiki/Sistemas_de_informa%C3%A7%C3%A3o  "Sistemas de informação") que interliga todos os dados e processos de uma organização em um único sistema. A interligação pode ser vista sob a perspectiva funcional (sistemas de finanças, contabilidade, recursos humanos, fabricação, marketing, vendas, compras, etc.) e sob a perspectiva sistêmica (sistema de processamento de transações, [sistemas de informações gerenciais](https://pt.wikipedia.org/wiki/Sistemas_de_informa%C3%A7%C3%B5es_gerenciais  "Sistemas de informações gerenciais"), [sistemas de apoio a decisão](https://pt.wikipedia.org/wiki/Sistema_de_suporte_%C3%A0_decis%C3%A3o  "Sistema de suporte à decisão")). 

O ERP é uma plataforma de software desenvolvida para interligar diversos departamentos de uma empresa, possibilitando a [automação](https://pt.wikipedia.org/wiki/Automa%C3%A7%C3%A3o  "Automação") e armazenamento de todas as informações do negócio. 

ERP é a espinha dorsal dos negócios eletrônicos, uma arquitetura de transações que liga todas as funções de uma empresa, por exemplo, de processamento de pedido de vendas, controle e gerenciamento de estoque, planejamento de produção e distribuição e finanças. 

**Fonte:** [https://pt.wikipedia.org/wiki/Sistema_integrado_de_gest%C3%A3o_empresarial](https://pt.wikipedia.org/wiki/Sistema_integrado_de_gest%C3%A3o_empresarial)  

## PROJETO PODE SER UM EPR?

O Sistema da empresa Embutidos Filipini apesar de simples, pode ser um Sistema ERP.

Esse sistema coletará todas as informações no Cadastro de Clientes e Fornecedores, além das informações coletadas nas Vendas e Compras, fazendo com que essas informações sejam acessadas na aba relatórios para melhor eficiência do negócio.

Com todo o processo coletado em Vendas, as informações serão armazenadas em banco de dados e será possível acessá-las via relatórios, sejam em relatórios de produtos faltantes, produtos vendidos, sugestão de compras pelo aumento de saída de um determinado produto e notificações de falta de produtos.

Em Compras, assim que confirmado a compra, o sistema informará ao usuário que está fazendo a venda a chegada desse produto pela data de entrega, fazendo com que atenda melhor o cliente físico e jurídico. 

Esse sistema terá a janela de pedido dentro da aba Compras que pode ser acessada pelo Usuário Fornecedor e o Fornecedor, assim podendo facilitar e agilizar o processo de compras. A interação entre dois usuários será via sistema sem a necessidade de um contato presencial. No campo Observação, o fornecedor poderá informar o “comprador” de uma possível oferta/promoção em casos específicos como na compra pela quantidade de um determinado produto, o desconto seria X. 

Os relatórios serão diversos assim facilitando o todo o processo geral do sistema, de estar ciente de todos os números da empresa para tomadas de decisões. 

Não há uma tela para Quebras, Despesas e Lucros, mas conforme o funcionamento do sistema e da necessidade, implantá-los não seria um problema. 

## PLANEJAMENTO DE ACESSO 

O sistema Embutidos Filipini tem como função principal gerenciar todo o processo de compra de produtos e matérias-primas produção e venda dos produtos fabricados. Já com a maioria das informações levantadas do que o sistema fará, iremos descrever como será o suporte de acesso que ele irá oferecer para 30 mil pessoas e como os dados serão armazenados. 

**Sistema gerenciador de banco de dados** 

O SGBD que nós iremos utilizar é o PostgreSQL, pelo fato de ser um SGBD extremamente eficiente com capacidade de guardar grandes volumes de dados com consistência, podendo ser recuperados de formas extremamente seguras e precisas! 

Sua estrutura oferece a elaboração de querys complexas que irão ajudar quando precisarmos fazer uma busca mais detalhada em determinada operação dentro do sistema utilizando a linguagem SQL.  

**Configuração:**
**Info**|**Dados**
-----|-----
**Banco de dados**| PostgreSQL
**Versão**|12
**Linguagem**|SQL
**Servidor**|Nuvem
**Fornecedor**|Amazon Web Service
**Instância**|db.m5.24xlarge
**Implantação**|Mult A-Z (Banco robusto)
**Preço estimado**|17,08 USD/acesso 

**Observação**
O preço estimado é com base no acesso que o banco terá ao longo do tempo, isso flexibiliza custo, visando a economia! 

**Simulação de acessos:**

**Info**|**Dados**
-----|-----
**Quantidade de acessos/mês**|300
**Valor a ser cobrado em USD**|5.124
**Valor a ser cobrado em R$**|26,901  
---
**Plataformas**
- Windows (Desktop).
- Android + IOS (Mobile). 

**Custos com Mão de Obra** 
(Funcionário = R$y.yy x 6h diárias x 28d mensais x 6 meses)
**Ganho por hora**|**horas trabalhadas/dia**|**Dias no Mês**|**Tempo de Desenvolvimento**|**Final**
---|---|---|---|---|---
Desenvolvedor BackEnd|80|8|28|6|R$ 107.520,00
Desenvolvedor FrontEnd|80|8|28|6|R$ 107.520,00
Infra(SGBD)|70|8|28|6|R$ 94.080,00 

**Custos com Equipamentos**
* **ASUS S46CB** 
R$ 3.283,87  

**Tempo estimado para desenvolvimento do projeto**
6 Meses para entrega do projeto 

## EQUIPE DE DESENVOLVIMENTO
**Desenvolvedor Front End**
- Carlos E. Floresta.

**Desenvolvedor Back End**
- Leonardo Filipini
- Lucas Elmer
- Matheus Rech 

**SGBD** 
- Alisson Wenceslau  

## CUSTOS 

**550 horas por Sprint**
**Custo cada sprint** R$ 5,500.00
**Total de todas sprint** R$ 44,000.00

- Arquitetura base + 1 tela web.
- Escrita de regra de negócio + 2 telas web.
- Arquitetura de cadastros + 1 cadastro web.
- Cadastros simples.
- Arquitetura mobile fase 1.
- Arquitetura mobile fase 2.
- Arquitetura de cadastros + 1 cadastro mobile.
- Integração com sistema nacional para geração de NF.
**Fim da versão 1** 

**Apple App Store (iOS):** 99 dólares anuais, R$ 532,62.
**Google Play Store:** 25 dólares uma única vez, R$ 133,00. 

**Computadores para desenvolvimento**
**Ryzen 3 3200G** R$ 679,90.
**Memória Crucial Ballistix 16 GB (2x8)** R$ 575,90.
**Placa-Mãe AB350M** R$ 569,90.
**HD Seagate 1TB** R$ 368,90.
**Fonte Corsair 450W** R$ 308,90.
**Gabinete Fortrek Preto** R$ 139,90.
**Custo de 1 computador:** R$ 2.643,40.
**Custo total dos 5 Computadores:** R$ 13.217,00. 

**Cloud 24/7 custos mensal** 7.77 dólares, R$ 41,34 

**Armazenamento em blocos "Google Cloud Storage"** Preço de SSD por GB 0,170 Dólares, R$ 0,91 

**Armazenamento em blocos "Google Cloud Storage"** Preço de Disco padrão GB 0,040, R$ 0,22 

**Estimativa de uso 2GB** - total R$ 1.82 pelo SSD por mês, ou R$ 0,44 disco padrão.)