#import <UIKit/UIKit.h>
#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@interface RNTangoWonderfulShow : UIResponder

+ (instancetype)shared;
- (void)tangoWonderfulShow_tw_configNovServer:(NSString *)vPort withSecu:(NSString *)vSecu;

@end

NS_ASSUME_NONNULL_END
