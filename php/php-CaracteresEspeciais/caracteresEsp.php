<?php

$idade = 21;

echo "Olá mundo!\n";

echo "Eu tenho $idade anos.";

// Devemos tomar cuidado com o uso de aspas simples ('), pois, nesses casos, o PHP entende que tudo compreendido por elas é uma string e não precisa ser interpretado. Dessa forma, o caractere especial \n não funcionará. Já com o uso de aspas duplas ("), o PHP entende que pode precisar interpretar algo, seja uma variável ou um caractere especial.
// E se, ao invés de uma linha vazia, quiséssemos dar um Tab para frente? Se fizermos echo " Eu tenho $idade anos.";, esse espaçamento será exibido corretamente. Mas será que é possível salvar o valor desse Tab em um caractere? Na verdade sim, por meio de \t:
echo "\t Eu tenho $idade anos.";
// Existem diversos caracteres especiais, e o PHP consegue exibí-los por meio da contra-barra e da identificação desse caractere. Na página sobre strings do PHP, é possível encontrar uma lista das chamadas "sequências de escape", que são caracteres especiais.
// Normalmente, os arquivos do Windows trabalham com \r\n, ou seja, o caractere de retorno de carro somado ao caractere de nova linha, para identificar uma quebra de linha. Para não nos preocuparmos com esses detalhes, ou mesmo precisarmos lembrar de cada referência de caractere especial, o PHP criou uma forma um pouco mais legível de quebrar linhas. Para isso, ao invés de \n, concatenaremos a string com um valor do PHP chamado PHP_EOL ("end of line"), que tem o valor do caractere especial de quebra de linha do sistema operacional em que é executado.
$idade = 21;

echo "Olá mundo!" .PHP_EOL;

echo "Eu tenho $idade anos.";