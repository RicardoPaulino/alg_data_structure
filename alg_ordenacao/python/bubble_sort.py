def bubble_sort(arr):
    if arr is None:
        raise TypeError("O array deve ser informado.")
    
    if len(arr) < 2:
        raise ValueError("O array deve possuir pelo menos 2 elementos.")
    
    swapped = 0;
    while True:
        swapped = 0;
        for i in range(len(arr) - 1):
            if arr[i] > arr[i + 1]:
                arr[i], arr[i + 1] = arr[i + 1], arr[i]
                swapped = i + 1
                
        if swapped == 0:
            break 
        
    return arr  
    
if __name__=="__main__":
    
    arr = [15,2,69,45,1]  
    bubble_sort(arr)
    for i, valor in enumerate(arr):
        print(f"indice {i} -> {valor}")