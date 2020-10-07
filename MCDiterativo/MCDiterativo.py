# MCD iterativo (GDC algorithm)
a= int(input(" introduzca un numero "))
b= int(input(" introduzca otro numero "))
def MCD(a, b):
    
    while b != 0:
        a, b = b, a%b
    return a
print (MCD(a,b)