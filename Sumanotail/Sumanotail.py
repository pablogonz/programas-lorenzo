# Sumatoria sin usar tail recursion
num= int(input(" introduzca un numero: "))
def Sumatoria(num):
    if num == 1:
        return 1
    
    else:
         return num + Sumatoria(num - 1)

print (Sumatoria(num))