# Factorial forma iterativo
n= int(input(" introduzca un numero que desea sacarle factorial "))
def Factorial(n):
    factor = 1
    for i in range(factor, n + 1):
        factor = factor * i
    return factor
print(Factorial(n))