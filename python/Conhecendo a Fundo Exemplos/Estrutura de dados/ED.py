vetor=[4,3,2,1]

print(vetor[0])
print(vetor[3])

#Utilizando o range()
soma = 0
for i in range(3):
  soma = soma + vetor[i]

#Utilizando o len()
soma = 0
for i in range(len(itens)):
  soma = soma + itens[i]
  
  #Leitura de todos os valores de uma vez:
valores = input("Digite os valores na mesma linha: ").split()

#Leitura um de cada vez:
valores=[None]*10
for i in range(len(valores)):
  valores[i] = input("Digite um valor: ")
  
  #Todos de uma vez:
numeros= [4,6,2,5,1,25,12,32]
print(numeros)

#Escrita um de cada vez:
numeros= [4,6,2,5,1,25,12,32]
for x in numeros:
  print(x, end=" ")
print()         