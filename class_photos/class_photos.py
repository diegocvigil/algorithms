def classPhotos(redShirtHeights, blueShirtHeights):
    redTallerThanBlue = True
    blueTallerThanRed = True
    
    redShirtHeights.sort()
    blueShirtHeights.sort()
    
    for idx in range(len(redShirtHeights)):
        redTallerThanBlue = redTallerThanBlue and redShirtHeights[idx] > blueShirtHeights[idx]
        blueTallerThanRed = blueTallerThanRed and blueShirtHeights[idx] > redShirtHeights[idx]
        
        if redTallerThanBlue == False and blueTallerThanRed == False:
            return False
        
    return True
