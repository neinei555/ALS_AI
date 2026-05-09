// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "ALS_AIGameMode.generated.h"

/**
 *  Simple GameMode for a third person game
 */
UCLASS(abstract)
class AALS_AIGameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	
	/** Constructor */
	AALS_AIGameMode();
};



