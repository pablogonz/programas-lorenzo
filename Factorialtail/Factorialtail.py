from tco import * 
# Factorial con tail recursion aplicado
n= int(input(" introduzca un numero limite "))
k= int(input(" introduzca el multiplicando "))
@with_continuations()
def Factorial(n, k, self=None):
    return self(n-1, k*n) if n > 1 else k

print (Factorial(n,k))