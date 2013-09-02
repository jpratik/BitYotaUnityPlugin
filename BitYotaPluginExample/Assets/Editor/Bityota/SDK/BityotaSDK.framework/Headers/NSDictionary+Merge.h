//
//  NSDictionary+Merge.h
//  Bityota
//
//  Created by Gregory Ray on 11/13/12.
//  Copyright (c) 2012 Bityota, Inc. All rights reserved.
//



#import <Foundation/Foundation.h>

@interface NSDictionary (Merge)

+ (NSDictionary *) dictionaryByMerging: (NSDictionary *) dict1 with: (NSDictionary *) dict2;
- (NSDictionary *) dictionaryByMergingWith: (NSDictionary *) dict;

@end