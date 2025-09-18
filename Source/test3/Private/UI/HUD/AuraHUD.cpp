// Copyright yxl


#include "UI/HUD/AuraHUD.h"

void AAuraHUD::BeginPlay()
{
	Super::BeginPlay();

	UUserWidget* Widget = CreateWidget<UUserWidget>(GetWorld(), OverlapWidgetClass);
	Widget->AddToViewport();
}
