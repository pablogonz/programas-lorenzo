# Factorial sin tail recursion 
n= int(input(" introduzca un numero que desea sacarle factorial: "))
def Factorial(n):
    if n == 0:
        return 1
    else:
        return n * Factorial(n - 1)

print (Factorial(n))