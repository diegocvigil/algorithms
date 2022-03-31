def tandemBicycle(redShirtSpeeds, blueShirtSpeeds, fastest):
    if fastest == True:
        redShirtSpeeds.sort(reverse=True)
    else:
        redShirtSpeeds.sort()

    blueShirtSpeeds.sort()
    
    sumSpeed = 0

    for idx in range(len(redShirtSpeeds)):
        if redShirtSpeeds[idx] > blueShirtSpeeds[idx]:
            sumSpeed += redShirtSpeeds[idx]
        else:
            sumSpeed += blueShirtSpeeds[idx]

    return sumSpeed


redShirtSpeeds = [5, 5, 3, 9, 2]
blueShirtSpeeds = [3, 6, 7, 2, 1] 
fastest = True
result = tandemBicycle(redShirtSpeeds, blueShirtSpeeds, fastest)
print(result)
