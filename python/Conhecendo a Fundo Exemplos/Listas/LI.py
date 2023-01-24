#Declarando  uma lista:
salada = []

#Incluindo valores:
salada = ["manda", "pera", "uva"]


#Incluindo valores:
salada = ["manda", "pera", "uva"]
print(salada)


salada.append("banana") 
print(salada)

salada.insert(2,"goiaba")
print(salada)
#Exemplo 1

#subprogramas
def preencher(listaElems, qtd, min, max):
    from random import randint              #Requer pacote com funcao externa
    for item in range(qtd):
        listaElems.append(randint(min, max))
    return None

#programa principal
qtdNumeros = int(input("A Lista deve ter quantos valores?"))
minimo = int(input("Menor valor da faixa:"))
maximo = int(input("Maior valor da faixa:"))
numeros = []
preencher(numeros, qtdNumeros, minimo, maximo)
print(numeros)

saladaComposta = ["banana", "caju", "uva", "pera", "manga", "kiwi"]
print(saladaComposta)
saladaSimples = saladaComposta[1:4]
print(saladaSimples)


#LISTAS DE LISTAS



mercado = [["pera", 100, 4.9], ["manga", 20, 3.9], ["uva", 30,5.9], ["caju", 15.35]]
print(mercado)

mercado = [["pera", 100, 4.9], ["manga", 20, 3.9], ["uva", 30,5.9], ["caju", 15.35]]
print(mercado)


mercado[1][2] *= 0.5  #Manga pela metade do preço
print(mercado)

mercado[3][1] -= 10  #caju com dez quilos a menos
print(mercado)

mercado.remove(["uva", 30,5.9])  #O produto uva é removido do mercado
print(mercado)

mercado.insert(1, ["kiwi", 200, 1.99])  #O produto kiwi é inserido
print(mercado)


def car(dados):
  return dados[0]
  
def cdr(dados):
  return dados[1:len(dados)]

def cons(item, dados):
  return [item] + dados


def soma(dados):
  if dados==[]:
    return 0 
  else:
    return car(dados) + soma(cdr(dados))