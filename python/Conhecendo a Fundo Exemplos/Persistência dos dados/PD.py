dados = open("caminho do arquivo", "r") #r: leitura ;
                                      #w: apenas escrita;
                                      #a: escreve no final do arquivo
                                         
dados.close()                         # o arquivo nao sera mais utilizado

               
dados = open("exemplo.txt", "r")

linha = dados.readline()

print(linha, end="")

dados.close()

dados_abrir=input("Digite o nome do arquivo que deseja visualizar: ")

dados = open(dados_abrir, "r")

linha = dados.readline()

while linha != "":
  print(linha, end="")
  linha=dados.readline()

dados.close()

dados_abrir=input("Digite o nome do arquivo que deseja visualizar: ")

dados = open(dados_abrir, "r")

for linha in dados:
  print(linha, end="")
dados.close()

dados_abrir = input("Digite o nome do arquivo:")
dados=open(dados_abrir, "r")
linhas = dados.readlines()

for linha in linhas:
  print(linha, end"")
  
dados.close()


dados=open("teste.txt", "w")
dados.write("qualquercoisa")

dados=open("teste.txt", "w")
dados.write("qualquercoisa\n")

arquivo = input("Digite o nome do arquivo que sera criado:")

qnt_linhas = int(input("Quantas linhas:"))

dados = open(arquivo, "w")

for i in range(qnt_linhas):
  nova=input("linha"+str(i+1)+":")
  dados.write(nova+"\n")
  
dados.close()

nome=input("Diga o nome do arquivo que deseja anexar")
arquivo=open(nome, "a")
noma_linha = input("Diga a nova linha:")
arquivo.write(nova_linha + "\n")
arquivo.close()