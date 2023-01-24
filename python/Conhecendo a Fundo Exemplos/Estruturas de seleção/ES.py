dinheiro = 50000

if dinheiro>10000:
  imps = dinheiro * 0.1
  multa = dinheiro * 0.15
  print( "Valor do Imposto:", imps, "e da multa:", multa)
  
    
#Estrutura de seleção de 2 ramos (if-else)
x=10
if x>0:
    print(x, "é maior do que zero.")
else:
else(x, "é menos ou igual a zero.")

#Estrutura de Seleção Aninhadas

""" 
Calcula ajuste de dinheiro, se tempo < 1 mantém , se tempo < 10 faz uma coisa, se tempo >= 10 faz outra:
"""
dinheiro = 1000.50
tempo = 20

if tempo<1:
  print("Seu dinheiro continua:", dinheiro)
else:
  if tempo<10:
    dinheiro = dinheiro * 1.1
  else:
    dinheiro = dinheiro * 1.2
  print("Seu dinheiro apos o ajuste:", dinheiro)
  
  
  #Estrutura de Seleção com Múltiplos Ramos (if-elif ou if-elif-else)
  
"""
Faremos um comando que funciona como calculadora.
"""

valores = [5,9]     #Poderiamos pedir que o usuario informasse com:
#valores=input("Digite dois valores: ").split()
x = int(valores[0])
y = int(valores[1])
op = "+"            #Poderiamos pedir que o usuario informasse

if op=="+":
  resultado = x+y
elif op=="-":
  resultado = x-y
elif op=="*":
  resultado = x*y
elif op=="/":
  resultado = x/y
elif op=="**":
  resultado = x**y
print(x,op,y,"=",resultado)
  
"""veja o exemplo a seguir com uso do if-elif-else :"""
  
  
  
"""
Faremos um comando que funciona como calculadora.
"""

valores = [5,9]     #Poderiamos pedir que o usuario informasse com:
#valores=input("Digite dois valores: ").split()
x = int(valores[0])
y = int(valores[1])
op = "+"            #Poderiamos pedir que o usuario informasse

if op=="+":
  resultado = x+y
elif op=="-":
  resultado = x-y
elif op=="*":
  resultado = x*y
elif op=="/":
  resultado = x/y
elif op=="**":
  resultado = x**y
else:
  resultado = None
if resultado == None:
  print(op, "Operador inexistente!!")
else:
  print(x,op,y,"=",resultado)