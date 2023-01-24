vazio = tuple()
print(vazio)
val = ("abacaxi", 500, 4.99)
print(val)

#ou ainda:

val = "abacaxi", 500, 4.99
print(val)

trio = tuple([1,2,3]) # ou trio = (1,2,3)
print(trio)

letras = tuple("aeiou") # ou letras = ("a", "e", "i", "o", "u")
print(letras)

individuo, altura = ("Maria Jose", 139)
print(individuo)
print(altura)

#ou ainda:

(nome, idade) = ("Maria Jose", 139)
print(nome)
print(idade)

#Iterando sobre os itens de uma tupla:

tomDePele = ("Marrom", "Amarelo", "Azul", "Branco")

for cor in tomDePele:
  print(cor)
  
  v = ("morango", 500, 4.99, 500)
print(v.count(500))           #Retorna quantidade

v = ("morango", 500, 4.99, 500)
print(v.index(500))            #Retorna indice