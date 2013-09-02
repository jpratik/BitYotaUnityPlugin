//
//  Bityota.h
//  Bityota
//
//  Created by Praveen Kumar
//  Copyright (c) 2013 Bityota, Inc. All rights reserved.
//

#import "NSDictionary+Merge.h"
#import "Reachability.h"
#import <Foundation/NSJSONSerialization.h>

@interface Bityota : NSObject {

    BOOL debugLogEnabled;
    BOOL isInit;
    NSString *trackingCode;
    NSString *vid;
    NSArray *validEventTypes;
    NSString *apiUrl;
    BOOL flushingEvents;
    BOOL statsEnabled;
    NSMutableDictionary *stats;

    // rule: only one of the below locks can be held at a single time by a given
    // thread

    // used to ensure that only a single thread at a time is flushing events to
    // Event Streaming Server
    NSLock *flushingEventsLock;

    // used to sync access to eventQueue, stored in NSUserDefaults; and to stats
    NSLock *eventQueueLock;

    // used to sync access to validEventTypes
    NSLock *validEventTypesLock;

    // used to sync access to serviceProvider
    NSLock *serviceProviderLock;

    NSString *sessionId;
    NSTimeInterval sessionStartTime;
    NSTimeInterval lastEventTime;
    dispatch_source_t flushEventsTimer;
    int flushEventsTimerPeriodSecs;
    int sendEventsBatchSize;
    int eventQueueFlushThresholdSize;
    int maxEventQueueLen;
    int sessionGapSecs;
    int tcConfigSyncPeriodMins;
    Reachability *reach;
    NSString *serviceProvider;
}

@property (nonatomic, retain) NSString *trackingCode;
@property (nonatomic, retain) NSString *vid;
@property (nonatomic, retain) NSArray *validEventTypes;
@property (nonatomic, retain) NSString *apiUrl;
@property (nonatomic, retain) NSMutableDictionary *stats;
@property (nonatomic, retain) NSLock *flushingEventsLock;
@property (nonatomic, retain) NSLock *eventQueueLock;
@property (nonatomic, retain) NSLock *validEventTypesLock;
@property (nonatomic, retain) NSLock *serviceProviderLock;
@property (nonatomic, retain) NSString *sessionId;
@property (nonatomic, retain) Reachability *reach;
@property (nonatomic, retain) NSString *serviceProvider;
@property (nonatomic, assign) int tcConfigSyncPeriodMins;

+ (Bityota *)instance;

- (void)initialize:(NSString *)appTrackingCode;

- (void)initialize:(NSString *)appTrackingCode withExtraParams:(NSDictionary *)extraParams;

- (id)startEventTimer;

- (void)sendEvent:(NSString*)type withData:(NSDictionary *)data;

- (void)sendEvent:(NSString*)type withData:(NSDictionary *)data withEventTimer:(id)eventTimer;

- (void)flushEvents;

- (int)getEventQueueSize;

- (void)setStatsEnabled:(BOOL)val;

- (void)clearStats;

- (NSString *)buildStatsStr;

- (void)clearEventQueue;

- (BOOL)getIsFlushingEvents;

@end
